﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;
using TSPGenetic.Algorithm.CrossoverOperators;
using TSPGenetic.Domain;

namespace TSPGenetic.Algorithm.UnitTests.CrossoverOperators
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class OnePointCrossoverUnitTests
    {
        private OnePointCrossover onePointCrossover;

        [TestInitialize]
        public void Setup()
        {
            onePointCrossover = new OnePointCrossover();
        }

        [TestMethod]
        public void TestThatCrossoverReturnsExpectedOffsprings()
        {
            const int crossoverPoint = 3;
            var parent1 = new Individual { Genes = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 } };
            var parent2 = new Individual { Genes = new int[] { 9, 3, 7, 8, 2, 6, 5, 1, 4 } };
            var expectedOffspring1 = new Individual { Genes = new int[] { 1, 2, 3, 8, 2, 6, 5, 1, 4 } };
            var expectedOffspring2 = new Individual { Genes = new int[] { 9, 3, 7, 4, 5, 6, 7, 8, 9 } };

            var result = onePointCrossover.PerformOnePointCrossover(parent1, parent2, crossoverPoint);

            CollectionAssert.AreEqual(expectedOffspring1.Genes, result.Item1.Genes);
            CollectionAssert.AreEqual(expectedOffspring2.Genes, result.Item2.Genes);
        }
    }
}
