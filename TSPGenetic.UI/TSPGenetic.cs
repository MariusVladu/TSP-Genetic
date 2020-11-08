using TSPGenetic.Algorithm;
using TSPGenetic.Algorithm.Contracts;
using TSPGenetic.Domain;
using TSPGenetic.Providers;
using TSPGenetic.Providers.Contracts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace TSPGenetic.UI
{
    public partial class TSPGenetic : Form
    {
        private GeneticAlgorithm geneticAlgorithm;
        private IFitnessFunction fitnessFunction;
        private ISelectionOperator selectionOperator;
        private IElitistSelection elitistSelection;
        private ICrossoverOperator crossoverOperator;
        private IMutationOperator mutationOperator;
        private IInitialPopulationProvider initialPopulationProvider;
        private Settings settings;

        private DataTable itemsTable;

        private List<double> generationsPlotData;
        private List<double> averageScorePlotData;
        private List<double> bestScorePlotData;

        public TSPGenetic()
        {
            InitializeComponent();

            itemsTable = new DataTable();
            itemsTable.Columns.Add("Weight");
            itemsTable.Columns.Add("Value");
            DisplayItems();

            fitnessFunction = new FitnessFunction();
            selectionOperator = new TournamentSelection(Convert.ToInt32(inputTournamentSize.Value));
            elitistSelection = new ElitistSelection();
            crossoverOperator = new CrossoverOperator();
            mutationOperator = new MutationOperator();
            initialPopulationProvider = new InitialPopulationProvider();

            InitializeGeneticAlgorithm();

            chartAverageScore.plt.XLabel("Generation #");
            chartAverageScore.plt.YLabel("Average Fitness Score");
            chartBestScore.plt.XLabel("Generation #");
            chartBestScore.plt.YLabel("Best Fitness Score");
            Plot();
        }

        private void DisplayItems()
        {
            var items = GetInitialItems();

            foreach (var item in items)
            {
                itemsTable.Rows.Add(item.Weight, item.Value);
            }

            inputItems.DataSource = itemsTable;
        }

        private List<City> GetItemsList()
        {
            var items = new List<City>();

            foreach (DataRow row in itemsTable.Rows)
            {
                items.Add(new City
                {
                    Weight = Convert.ToInt32(row["Weight"]),
                    Value = Convert.ToInt32(row["Value"])
                });
            }

            return items;
        }

        private void InitializeGeneticAlgorithm()
        {
            var items = GetItemsList();

            settings = new Settings
            {
                Cities = items,
                NumberOfGenes = items.Count,
                WeightLimit = Convert.ToInt32(inputWeightLimit.Value),
                NumberOfElites = Convert.ToInt32(inputElites.Value),
                InitialPopulationSize = Convert.ToInt32(inputMaxPopulation.Value),
                MaxPopulationSize = Convert.ToInt32(inputMaxPopulation.Value),
                CrossoverRate = Convert.ToDouble(inputCrossoverRate.Value),
                MutationRate = Convert.ToDouble(inputMutationRate.Value)
            };

            selectionOperator = new TournamentSelection(Convert.ToInt32(inputTournamentSize.Value));

            geneticAlgorithm = new GeneticAlgorithm(settings, initialPopulationProvider, fitnessFunction, selectionOperator, elitistSelection, crossoverOperator, mutationOperator);

            generationsPlotData = new List<double>();
            averageScorePlotData = new List<double>();
            bestScorePlotData = new List<double>();
            UpdatePlotData();
        }

        private void buttonNextGeneration_Click(object sender, EventArgs e)
        {
            geneticAlgorithm.ComputeNextGeneration();

            UpdatePlotData();
            Plot();
        }

        private void UpdatePlotData()
        {
            generationsPlotData.Add(geneticAlgorithm.CurrentGenerationNumber);
            averageScorePlotData.Add(geneticAlgorithm.AverageScore);
            bestScorePlotData.Add(geneticAlgorithm.CurrentBestSolution.FitnessScore);
        }

        private void Plot()
        {
            var generationsPlotArray = generationsPlotData.ToArray();

            chartAverageScore.plt.Clear();
            chartAverageScore.plt.PlotScatter(generationsPlotArray, averageScorePlotData.ToArray(), Color.Blue);
            chartAverageScore.plt.AxisAuto();
            chartAverageScore.Render();

            chartBestScore.plt.Clear();
            chartBestScore.plt.PlotScatter(generationsPlotArray, bestScorePlotData.ToArray(), Color.Green);
            chartBestScore.plt.AxisAuto();
            chartBestScore.Render();

            ShowBestSolution();
        }

        private void ShowBestSolution()
        {
            var generationNumberString = geneticAlgorithm.CurrentGenerationNumber.ToString().PadLeft(4, '0'); ;
            var averageScore2DecimalPlaces = string.Format("{0:00.00}", geneticAlgorithm.AverageScore);
            labelGenerationInfo.Text = $"Generation #{generationNumberString}\nAverage: {averageScore2DecimalPlaces}\nBest Solution: {geneticAlgorithm.CurrentBestSolution}\nBest Score: {geneticAlgorithm.CurrentBestSolution.FitnessScore}";
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            InitializeGeneticAlgorithm();

            var stopwatch = new Stopwatch();

            for (int i = 0; i < inputGenerationsNumber.Value; i++)
            {
                stopwatch.Start();
                geneticAlgorithm.ComputeNextGeneration();
                stopwatch.Stop();

                UpdatePlotData();

                if (i % 50 == 0) Plot();
            }

            Plot();
            DisplayEllapsedTime(stopwatch.Elapsed);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            InitializeGeneticAlgorithm();
            Plot();
        }

        private List<City> GetInitialItems()
        {
            return new List<City>
            {
                new City{ Weight = 7, Value = 5},
                new City{ Weight = 2, Value = 4},
                new City{ Weight = 1, Value = 7},
                new City{ Weight = 9, Value = 2},
                new City{ Weight = 20, Value = 5},
                new City{ Weight = 11, Value = 6},
                new City{ Weight = 2, Value = 6},
                new City{ Weight = 15, Value = 10},
                new City{ Weight = 3, Value = 1},
                new City{ Weight = 4, Value = 2},
                new City{ Weight = 8, Value = 5},
            };
        }

        private void DisplayEllapsedTime(TimeSpan elapsedTime)
        {
            labelGenerationInfo.Text += $"\nElapsed Time: {elapsedTime.TotalMilliseconds} ms";
        }
    }
}
