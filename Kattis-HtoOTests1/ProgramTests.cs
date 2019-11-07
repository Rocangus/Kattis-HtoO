using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            var actual = new Dictionary<char, int>() 
            { { 'C', 1 }, { 'H', 4 }, { 'O', 1 } };
            var inputStrings = new string[2] { "CH3OH", "5" };
            var expected = new Dictionary<char, int>() 
            { { 'C', 5 }, { 'H', 20 }, { 'O', 5 } };
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
            var expected = new Dictionary<char, int>() 
                { { 'C', 1 }, { 'H', 3 }, { 'O', 1 } };

            // Act
            actual = Program.UpdateAtomCounts(actual, 'C', 1);
            actual = Program.UpdateAtomCounts(actual, 'H', 3);
            actual = Program.UpdateAtomCounts(actual, 'O', 1);

            // Assert
            CollectionAssert.AreEquivalent(actual, expected);
        }

        [TestMethod()]
        public void DetermineAtomCountTest()
        {
            // Arrange
            var input = "CH3C60";
            int actual1, actual2, actual3, i, j, k;
            var expected1 = 1;
            var expected2 = 3;
            var expected3 = 60;

            // Act
            i = 0;
            actual1 = Program.DetermineAtomCount(input, ref i);
            j = 1;
            actual2 = Program.DetermineAtomCount(input, ref j);
            k = 3;
            actual3 = Program.DetermineAtomCount(input, ref k);

            // Assert
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(i, 0);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(j, 2);
            Assert.AreEqual(expected3, actual3);
            Assert.AreEqual(k, 5);
        }

        [TestMethod()]
        public void ParseInputTestForSourceMaterials1()
        {
            // Arrange
            var atoms = new Dictionary<char, int>();
            var inputStringArray = new string[2] { "H", "2" };
            var expected = new Dictionary<char, int>()
            { {'H', 2} };
            var inputIsSource = true;

            // Act
            var actual = Program.ParseInput(atoms, inputStringArray, inputIsSource);

            // Assert
            CollectionAssert.AreEquivalent(actual, expected);
        }

        [TestMethod()]
        public void ParseInputTestForSourceMaterials2()
        {
            // Arrange
            var atoms = new Dictionary<char, int>();
            var inputStringArray = new string[2] { "C2H6", "10" };
            var expected = new Dictionary<char, int>()
            { {'C', 20 }, {'H', 60} };
            var inputIsSource = true;

            // Act
            var actual = Program.ParseInput(atoms, inputStringArray, inputIsSource);

            // Assert
            CollectionAssert.AreEquivalent(actual, expected);
        }

        [TestMethod()]
        public void ParseInputTestForSourceMaterials3()
        {
            // Arrange
            var atoms = new Dictionary<char, int>();
            var inputStringArray = new string[2] { "CH3OH", "1" };
            var expected = new Dictionary<char, int>()
            { {'C', 1 }, {'H', 4}, {'O', 1 } };
            var inputIsSource = true;

            // Act
            var actual = Program.ParseInput(atoms, inputStringArray, inputIsSource);

            // Assert
            CollectionAssert.AreEquivalent(actual, expected);
        }
        
        [TestMethod()]
        public void ParseInputTestForSourceMaterials4()
        {
            // Arrange
            var atoms = new Dictionary<char, int>();
            var inputStringArray = new string[2] { "C6H6OCH2O", "10" };
            var expected = new Dictionary<char, int>()
            { {'C', 70 }, {'H', 80 }, {'O', 20 } };
            var inputIsSource = true;

            // Act
            var actual = Program.ParseInput(atoms, inputStringArray, inputIsSource);

            // Assert
            CollectionAssert.AreEquivalent(actual, expected);
        }

        [TestMethod()]
        public void ParseInputTestForSourceMaterials5()
        {
            // Arrange
            var atoms = new Dictionary<char, int>();
            var inputStringArray = new string[2] { "C6H14", "10" };
            var expected = new Dictionary<char, int>()
            { {'C', 60 }, {'H', 140} };
            var inputIsSource = true;

            // Act
            var actual = Program.ParseInput(atoms, inputStringArray, inputIsSource);

            // Assert
            CollectionAssert.AreEquivalent(actual, expected);
        }

        [TestMethod()]
        public void ParseInputTestForSourceMaterials6()
        {
            // Arrange
            var atoms = new Dictionary<char, int>();
            var inputStringArray = new string[2] { "AB2CD1", "2" };
            var expected = new Dictionary<char, int>()
            { {'A', 2 }, {'B', 4 }, {'C', 2 }, {'D', 2} };
            var inputIsSource = true;

            // Act
            var actual = Program.ParseInput(atoms, inputStringArray, inputIsSource);

            // Assert
            CollectionAssert.AreEquivalent(actual, expected);
        }

        [TestMethod()]
        public void ParseInputTestForProduct1()
        {
            // Arrange
            var atoms = new Dictionary<char, int>();
            var inputStringArray = new string[1] { "O" };
            var expected = new Dictionary<char, int>()
            { {'O', 1 }};
            var inputIsSource = false;

            // Act
            var actual = Program.ParseInput(atoms, inputStringArray, inputIsSource);

            // Assert
            CollectionAssert.AreEquivalent(actual, expected);
        }

        [TestMethod()]
        public void ParseInputTestForProduct2()
        {
            // Arrange
            var atoms = new Dictionary<char, int>();
            var inputStringArray = new string[1] { "C3H8" };
            var expected = new Dictionary<char, int>()
            { {'C', 3 }, {'H', 8} };
            var inputIsSource = false;

            // Act
            var actual = Program.ParseInput(atoms, inputStringArray, inputIsSource);

            // Assert
            CollectionAssert.AreEquivalent(actual, expected);
        }

        [TestMethod()]
        public void ParseInputTestForProduct3()
        {
            // Arrange
            var atoms = new Dictionary<char, int>();
            var inputStringArray = new string[1] { "CH4" };
            var expected = new Dictionary<char, int>()
            { {'C', 1 }, {'H', 4} };
            var inputIsSource = false;

            // Act
            var actual = Program.ParseInput(atoms, inputStringArray, inputIsSource);

            // Assert
            CollectionAssert.AreEquivalent(actual, expected);
        }

        [TestMethod()]
        public void ParseInputTestForProduct4()
        {
            // Arrange
            var atoms = new Dictionary<char, int>();
            var inputStringArray = new string[1] { "HCN" };
            var expected = new Dictionary<char, int>()
            { {'C', 1 }, {'H', 1}, {'N', 1 } };
            var inputIsSource = false;

            // Act
            var actual = Program.ParseInput(atoms, inputStringArray, inputIsSource);

            // Assert
            CollectionAssert.AreEquivalent(actual, expected);
        }


        [TestMethod()]
        public void ParseInputTestForProduct5()
        {
            // Arrange
            var atoms = new Dictionary<char, int>();
            var inputStringArray = new string[1] { "C5H10" };
            var expected = new Dictionary<char, int>()
            { {'C', 5 }, {'H', 10} };
            var inputIsSource = false;

            // Act
            var actual = Program.ParseInput(atoms, inputStringArray, inputIsSource);

            // Assert
            CollectionAssert.AreEquivalent(actual, expected);
        }

        
        [TestMethod()]
        public void ParseInputTestForProduct6()
        {
            // Arrange
            var atoms = new Dictionary<char, int>();
            var inputStringArray = new string[1] { "A2B3CD2" };
            var expected = new Dictionary<char, int>()
            { {'A', 2 }, {'B', 3}, {'C', 1 }, {'D', 2 } };
            var inputIsSource = false;

            // Act
            var actual = Program.ParseInput(atoms, inputStringArray, inputIsSource);

            // Assert
            CollectionAssert.AreEquivalent(actual, expected);
        }
    }
}