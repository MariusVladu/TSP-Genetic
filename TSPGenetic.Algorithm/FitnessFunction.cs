using TSPGenetic.Algorithm.Contracts;
using TSPGenetic.Domain;
using System.Collections.Generic;

namespace TSPGenetic.Algorithm
{
    public class FitnessFunction : IFitnessFunction
    {
        public int GetFitnessScore(Individual individual, int weightLimit, List<Item> items)
        {
            var score = 0;
            var totalWeight = 0;
            
            for (int i = 0; i < items.Count; i++)
            {
                if (individual.Genes[i] == true)
                {
                    score += items[i].Value;
                    totalWeight += items[i].Weight;
                }
            }

            return totalWeight <= weightLimit
                ? score
                : 0;
        }
    }
}
