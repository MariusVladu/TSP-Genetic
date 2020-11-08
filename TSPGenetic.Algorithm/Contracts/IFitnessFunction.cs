using TSPGenetic.Domain;
using System.Collections.Generic;

namespace TSPGenetic.Algorithm.Contracts
{
    public interface IFitnessFunction
    {
        int GetFitnessScore(Individual individual, int weightLimit, List<Item> items);
    }
}
