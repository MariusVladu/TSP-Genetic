﻿using System.Collections.Generic;

namespace TSPGenetic.Domain
{
    public class Settings
    {
        public List<Item> Items { get; set; }
        public int NumberOfGenes { get; set; }
        public int WeightLimit { get; set; }
        public int NumberOfElites { get; set; }
        public int InitialPopulationSize { get; set; }
        public int MaxPopulationSize { get; set; }
        public double CrossoverRate { get; set; }
        public double MutationRate { get; set; }
    }
}
