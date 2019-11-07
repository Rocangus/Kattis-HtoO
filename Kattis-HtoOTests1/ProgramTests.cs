﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kattis_HtoO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kattis_HtoO.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void MultiplySourceMoleculeTest()
        {
            // Arrange
            var actual = new Dictionary<char, int>() { { 'C', 1 }, { 'H', 4 }, { 'O', 1 } };
            var inputStrings = new string[2] { "CH3OH", "5" };
            var expected = new Dictionary<char, int>() { { 'C', 5 }, { 'H', 20 }, { 'O', 5 } };
            // Act
            actual = Program.MultiplySourceMolecule(actual, inputStrings);

            // Assert
            CollectionAssert.AreEquivalent(actual, expected);
        }

        [TestMethod()]
        public void UpdateAtomCountsTest()
        {
            // Arrange
            var actual = new Dictionary<char, int>();
            var expected = new Dictionary<char, int>() { { 'C', 1 }, { 'H', 3 }, { 'O', 1 } };

            // Act
            actual = Program.UpdateAtomCounts(actual, 'C', 1);
            actual = Program.UpdateAtomCounts(actual, 'H', 3);
            actual = Program.UpdateAtomCounts(actual, 'O', 1);

            // Assert
            CollectionAssert.AreEquivalent(actual, expected);
        }
    }
}