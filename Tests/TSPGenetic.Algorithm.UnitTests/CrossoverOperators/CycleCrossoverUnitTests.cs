﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;
using TSPGenetic.Algorithm.CrossoverOperators;
using TSPGenetic.Domain;

namespace TSPGenetic.Algorithm.UnitTests.CrossoverOperators
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class CycleCrossoverUnitTests
    {
        private CycleCrossover cycleCrossover;

        [TestInitialize]
        public void Setup()
        {
            cycleCrossover = new CycleCrossover();
        }

        [TestMethod]
        public void TestThatOffspringsAreReturnedAsExpected()
        {
            var parent1 = new Individual { Genes = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 } };
            var parent2 = new Individual { Genes = new int[] { 9, 3, 7, 8, 2, 6, 5, 1, 4 } };
            var expectedOffspring1Genes = new int[] { 1, 3, 7, 4, 2, 6, 5, 8, 9 };
            var expectedOffspring2Genes = new int[] { 9, 2, 3, 8, 5, 6, 7, 1, 4 };

            var result = cycleCrossover.PerformCycleCrossover(parent1, parent2);

            CollectionAssert.AreEqual(expectedOffspring1Genes, result.Item1.Genes);
            CollectionAssert.AreEqual(expectedOffspring2Genes, result.Item2.Genes);
        }
    }
}
