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
            sourceAtoms = ParseInput(sourceAtoms, inputStrings, inputIsSource);
            string outputMolecule = Console.ReadLine();
        }

        public static Dictionary<char, int> ParseInput(Dictionary<char, int> atoms, string[] inputStringArray, bool inputIsSource)
        {
            var input = inputStringArray[0];
            for (int i = 0; i < input.Length; i++)
            {
                var c = input[i];
                if (!char.IsDigit(c))
                {
                    int value = DetermineAtomCount(input, ref i);
                    atoms = UpdateAtomCounts(atoms, c, value);
                }
            }
            if (inputIsSource)
            {
                MultiplySourceMolecule(atoms, inputStringArray);
            }
            return atoms;
        }

        public static int DetermineAtomCount(string input, ref int i)
        {
            List<int> ints = new List<int>();
            int x = i + 1;
            int value;
            while (x < input.Length && char.IsDigit(input[x]))
            {
                ints.Add((int)char.GetNumericValue(input[x]));
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

        public static Dictionary<char, int> UpdateAtomCounts(Dictionary<char, int> atoms, char c, int value)
        {
            if (atoms.ContainsKey(c))
            {
                atoms[c] += value;
            }
            else
            {
                atoms.Add(c, value);
            }
            return atoms;
        }

        public static Dictionary<char, int> MultiplySourceMolecule(Dictionary<char, int> atoms, string[] inputStrings)
        {
            if (inputStrings.Length == 2)
            {
                var countMultiplier = int.Parse(inputStrings[1]);
                var keys = new char[atoms.Keys.Count];
                atoms.Keys.CopyTo(keys, 0);
                for(var i = 0; i < keys.Length; i++)
                {
                    var key = keys[i];
                    atoms[key] *= countMultiplier;
                }
            }
            return atoms;
        }
    }
}
