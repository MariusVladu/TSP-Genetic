﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using TSPGenetic.Algorithm.CrossoverOperators;
using TSPGenetic.Domain;

namespace TSPGenetic.Algorithm.UnitTests.CrossoverOperators
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class OrderOneCrossoverUnitTests
    {
        private OrderOneCrossover orderOneCrossover;

        [TestInitialize]
        public void Setup()
        {
            orderOneCrossover = new OrderOneCrossover();
        }

        [TestMethod]
        public void TestThatCrossoverReturnsExpectedOffsprings()
        {
            const int left = 3;
            const int right = 7;
            var parent1 = new Individual { Genes = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 } };
            var parent2 = new Individual { Genes = new int[] { 9, 3, 7, 8, 2, 6, 5, 1, 4 } };
            var expectedOffspring1 = new Individual { Genes = new int[] { 3, 8, 2, 4, 5, 6, 7, 1, 9 } };
            var expectedOffspring2 = new Individual { Genes = new int[] { 3, 4, 7, 8, 2, 6, 5, 9, 1 } };

            var result = orderOneCrossover.PerformOrderOneCrossover(parent1, parent2, left, right);

            CollectionAssert.AreEqual(expectedOffspring1.Genes, result.Item1.Genes);
            CollectionAssert.AreEqual(expectedOffspring2.Genes, result.Item2.Genes);
        }

        [TestMethod]
        public void TestThatOffspringsAreDifferent()
        {
            const int left = 3;
            const int right = 7;
            var parent1 = new Individual { Genes = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 } };
            var parent2 = new Individual { Genes = new int[] { 9, 3, 7, 8, 2, 6, 5, 1, 4 } };

            var result = orderOneCrossover.PerformOrderOneCrossover(parent1, parent2, left, right);

            CollectionAssert.AreNotEqual(result.Item1.Genes, result.Item2.Genes);
        }

        [TestMethod]
        public void TestThatOffspringsHaveOnlyDistinctGenes()
        {
            const int left = 3;
            const int right = 7;
            var parent1 = new Individual { Genes = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 } };
            var parent2 = new Individual { Genes = new int[] { 9, 3, 7, 8, 2, 6, 5, 1, 4 } };

            var result = orderOneCrossover.PerformOrderOneCrossover(parent1, parent2, left, right);

            var distinctOffspring1Genes = result.Item1.Genes.Distinct();
            var distinctOffspring2Genes = result.Item2.Genes.Distinct();
            Assert.IsTrue(distinctOffspring1Genes.Count() == result.Item1.Genes.Length);
            Assert.IsTrue(distinctOffspring2Genes.Count() == result.Item2.Genes.Length);
        }

        [TestMethod]
        public void TestThatWhenLeftIsGreaterThanRightTheyAreSwappedAndResultIsAsExpected()
        {

            const int left = 7;
            const int right = 3;
            var parent1 = new Individual { Genes = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 } };
            var parent2 = new Individual { Genes = new int[] { 9, 3, 7, 8, 2, 6, 5, 1, 4 } };
            var expectedOffspring1 = new Individual { Genes = new int[] { 3, 8, 2, 4, 5, 6, 7, 1, 9 } };
            var expectedOffspring2 = new Individual { Genes = new int[] { 3, 4, 7, 8, 2, 6, 5, 9, 1 } };

            var result = orderOneCrossover.PerformOrderOneCrossover(parent1, parent2, left, right);

            CollectionAssert.AreEqual(expectedOffspring1.Genes, result.Item1.Genes);
            CollectionAssert.AreEqual(expectedOffspring2.Genes, result.Item2.Genes);
        }
    }
}
