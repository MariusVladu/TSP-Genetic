using TSPGenetic.Domain;
using System;
using TSPGenetic.Algorithm.CrossoverOperators;

namespace TSPGenetic.CrossoverOperators.Algorithm
{
    public class OnePointCrossover : BaseCrossoverOperator
    {
        protected override Tuple<Individual, Individual> PerformCrossover(Individual parent1, Individual parent2)
        {
            var numberOfGenes = parent1.Genes.Length;
            var crossoverPoint = random.Next(numberOfGenes);

            var offspring1 = new Individual { Genes = new int[numberOfGenes] };
            var offspring2 = new Individual { Genes = new int[numberOfGenes] };

            for (int i = 0; i < numberOfGenes; i++)
            {
                if (i < crossoverPoint)
                {
                    offspring1.Genes[i] = parent1.Genes[i];
                    offspring2.Genes[i] = parent2.Genes[i];
                }
                else
                {
                    offspring1.Genes[i] = parent2.Genes[i];
                    offspring2.Genes[i] = parent1.Genes[i];
                }
            }

            return new Tuple<Individual, Individual>(offspring1, offspring2);
        }
    }
}
