﻿using TSPGenetic.Algorithm.Contracts;
using TSPGenetic.Domain;
using System;

namespace TSPGenetic.Algorithm
{
    public class MutationOperator : IMutationOperator
    {
        private static readonly Random random = new Random();

        public void ApplyMutation(Individual individual, double mutationRate)
        {
            for (int i = 0; i < individual.Genes.Length; i++)
                if(random.NextDouble() < mutationRate)
                    individual.Genes[i] = !individual.Genes[i];
        }
    }
}
