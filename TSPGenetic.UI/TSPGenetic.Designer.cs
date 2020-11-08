﻿namespace TSPGenetic.UI
{
    partial class TSPGenetic
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonNextGeneration = new System.Windows.Forms.Button();
            this.chartAverageScore = new ScottPlot.FormsPlot();
            this.labelGenerationInfo = new System.Windows.Forms.Label();
            this.buttonRun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.inputGenerationsNumber = new System.Windows.Forms.NumericUpDown();
            this.chartBestScore = new ScottPlot.FormsPlot();
            this.label2 = new System.Windows.Forms.Label();
            this.inputMutationRate = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.inputCrossoverRate = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.inputMaxPopulation = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.inputElites = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.inputTournamentSize = new System.Windows.Forms.NumericUpDown();
            this.buttonReset = new System.Windows.Forms.Button();
            this.inputWeightLimit = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.inputItems = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.inputGenerationsNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputMutationRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputCrossoverRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputMaxPopulation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputElites)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTournamentSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputWeightLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputItems)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNextGeneration
            // 
            this.buttonNextGeneration.Location = new System.Drawing.Point(12, 12);
            this.buttonNextGeneration.Name = "buttonNextGeneration";
            this.buttonNextGeneration.Size = new System.Drawing.Size(113, 23);
            this.buttonNextGeneration.TabIndex = 0;
            this.buttonNextGeneration.Text = "Next Generation";
            this.buttonNextGeneration.UseVisualStyleBackColor = true;
            this.buttonNextGeneration.Click += new System.EventHandler(this.buttonNextGeneration_Click);
            // 
            // chartAverageScore
            // 
            this.chartAverageScore.Location = new System.Drawing.Point(13, 41);
            this.chartAverageScore.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chartAverageScore.Name = "chartAverageScore";
            this.chartAverageScore.Size = new System.Drawing.Size(568, 327);
            this.chartAverageScore.TabIndex = 1;
            // 
            // labelGenerationInfo
            // 
            this.labelGenerationInfo.AutoSize = true;
            this.labelGenerationInfo.Location = new System.Drawing.Point(603, 56);
            this.labelGenerationInfo.Name = "labelGenerationInfo";
            this.labelGenerationInfo.Size = new System.Drawing.Size(108, 15);
            this.labelGenerationInfo.TabIndex = 2;
            this.labelGenerationInfo.Text = "Current Generation";
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(506, 12);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(75, 23);
            this.buttonRun.TabIndex = 3;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Generations";
            // 
            // inputGenerationsNumber
            // 
            this.inputGenerationsNumber.Location = new System.Drawing.Point(429, 12);
            this.inputGenerationsNumber.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.inputGenerationsNumber.Name = "inputGenerationsNumber";
            this.inputGenerationsNumber.Size = new System.Drawing.Size(71, 23);
            this.inputGenerationsNumber.TabIndex = 5;
            this.inputGenerationsNumber.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // chartBestScore
            // 
            this.chartBestScore.Location = new System.Drawing.Point(13, 374);
            this.chartBestScore.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chartBestScore.Name = "chartBestScore";
            this.chartBestScore.Size = new System.Drawing.Size(568, 327);
            this.chartBestScore.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(603, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tournament Size";
            // 
            // inputMutationRate
            // 
            this.inputMutationRate.DecimalPlaces = 2;
            this.inputMutationRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.inputMutationRate.Location = new System.Drawing.Point(712, 285);
            this.inputMutationRate.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputMutationRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.inputMutationRate.Name = "inputMutationRate";
            this.inputMutationRate.Size = new System.Drawing.Size(71, 23);
            this.inputMutationRate.TabIndex = 5;
            this.inputMutationRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(603, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mutation Rate";
            // 
            // inputCrossoverRate
            // 
            this.inputCrossoverRate.DecimalPlaces = 2;
            this.inputCrossoverRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.inputCrossoverRate.Location = new System.Drawing.Point(712, 256);
            this.inputCrossoverRate.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputCrossoverRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.inputCrossoverRate.Name = "inputCrossoverRate";
            this.inputCrossoverRate.Size = new System.Drawing.Size(71, 23);
            this.inputCrossoverRate.TabIndex = 5;
            this.inputCrossoverRate.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(603, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Crossover Rate";
            // 
            // inputMaxPopulation
            // 
            this.inputMaxPopulation.Location = new System.Drawing.Point(712, 227);
            this.inputMaxPopulation.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.inputMaxPopulation.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputMaxPopulation.Name = "inputMaxPopulation";
            this.inputMaxPopulation.Size = new System.Drawing.Size(71, 23);
            this.inputMaxPopulation.TabIndex = 5;
            this.inputMaxPopulation.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(603, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Max Population";
            // 
            // inputElites
            // 
            this.inputElites.Location = new System.Drawing.Point(712, 198);
            this.inputElites.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.inputElites.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputElites.Name = "inputElites";
            this.inputElites.Size = new System.Drawing.Size(71, 23);
            this.inputElites.TabIndex = 5;
            this.inputElites.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(603, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "# Elites";
            // 
            // inputTournamentSize
            // 
            this.inputTournamentSize.Location = new System.Drawing.Point(712, 314);
            this.inputTournamentSize.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.inputTournamentSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputTournamentSize.Name = "inputTournamentSize";
            this.inputTournamentSize.Size = new System.Drawing.Size(71, 23);
            this.inputTournamentSize.TabIndex = 5;
            this.inputTournamentSize.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(603, 12);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 7;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // inputWeightLimit
            // 
            this.inputWeightLimit.Location = new System.Drawing.Point(712, 360);
            this.inputWeightLimit.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.inputWeightLimit.Name = "inputWeightLimit";
            this.inputWeightLimit.Size = new System.Drawing.Size(71, 23);
            this.inputWeightLimit.TabIndex = 5;
            this.inputWeightLimit.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(603, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Weight Limit";
            // 
            // inputItems
            // 
            this.inputItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inputItems.Location = new System.Drawing.Point(603, 389);
            this.inputItems.Name = "inputItems";
            this.inputItems.Size = new System.Drawing.Size(261, 282);
            this.inputItems.TabIndex = 8;
            this.inputItems.Text = "dataGridView1";
            // 
            // TSPGenetic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 736);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.inputWeightLimit);
            this.Controls.Add(this.inputItems);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.inputTournamentSize);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.inputElites);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inputMaxPopulation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputCrossoverRate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputMutationRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chartBestScore);
            this.Controls.Add(this.inputGenerationsNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.labelGenerationInfo);
            this.Controls.Add(this.chartAverageScore);
            this.Controls.Add(this.buttonNextGeneration);
            this.Name = "TSPGenetic";
            this.Text = "TSPGenetic";
            ((System.ComponentModel.ISupportInitialize)(this.inputGenerationsNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputMutationRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputCrossoverRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputMaxPopulation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputElites)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputTournamentSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputWeightLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNextGeneration;
        private ScottPlot.FormsPlot chartAverageScore;
        private System.Windows.Forms.Label labelGenerationInfo;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown inputGenerationsNumber;
        private ScottPlot.FormsPlot chartBestScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown inputMutationRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown inputCrossoverRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown inputMaxPopulation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown inputElites;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown inputTournamentSize;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.DataGridView inputItems;
        private System.Windows.Forms.NumericUpDown inputWeightLimit;
        private System.Windows.Forms.Label label7;
    }
}

