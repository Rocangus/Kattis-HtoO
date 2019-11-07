using System;
using System.Collections.Generic;

namespace Kattis_HtoO
{
    public class Program
    {
        static bool inputIsSource;
        static void Main(string[] args)
        {
            Dictionary<char, int> sourceAtoms = new Dictionary<char, int>();
            Dictionary<char, int> productMolecule = new Dictionary<char, int>();
            string input = Console.ReadLine();
            inputIsSource = true;
            var inputStrings = input.Split();
            sourceAtoms = ParseInput(sourceAtoms, inputStrings);
            string outputMolecule = Console.ReadLine();
        }

        public static Dictionary<char, int> ParseInput(Dictionary<char, int> atoms, string[] inputStringArray)
        {
            var inputSource = inputStringArray[0];
            for (int i = 0; i < inputSource.Length; i++)
            {
                var c = inputSource[i];
                if (!char.IsDigit(c))
                {
                    List<int> ints = new List<int>();
                    int value = DetermineAtomCount(inputSource, ref i, ints);
                    UpdateAtomCounts(atoms, c, value);
                }
            }
            if (inputIsSource) MultiplySourceMolecule(atoms, inputStringArray);
            return atoms;
        }

        public static int DetermineAtomCount(string inputSource, ref int i, List<int> ints)
        {
            int x = i + 1;
            int value;
            while (x < inputSource.Length && char.IsDigit(inputSource[x]))
            {
                ints.Add((int)char.GetNumericValue(inputSource[x]));
                x++;
            }
            if (ints.Count > 0)
            {
                value = int.Parse(String.Concat(ints));
                i += ints.Count;
            }
            else { value = 1; }

            return value;
        }

        public static void UpdateAtomCounts(Dictionary<char, int> sourceAtoms, char c, int value)
        {
            if (sourceAtoms.ContainsKey(c))
            {
                sourceAtoms[c] += value;
            }
            else
            {
                sourceAtoms.Add(c, value);
            }
        }

        public static void MultiplySourceMolecule(Dictionary<char, int> sourceAtoms, string[] inputStrings)
        {
            if (inputStrings.Length == 2)
            {
                var countMultiplier = int.Parse(inputStrings[1]);
                foreach (var key in sourceAtoms.Keys)
                {
                    sourceAtoms[key] *= countMultiplier;
                }
            }
        }
    }
}
