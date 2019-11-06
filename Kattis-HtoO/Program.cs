using System;
using System.Collections.Generic;

namespace Kattis_HtoO
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> sourceMolecules = new Dictionary<char, int>();
            Dictionary<char, int> productMolecule = new Dictionary<char, int>();
            string input = Console.ReadLine();
            string outputMolecule = Console.ReadLine();
            var inputStrings = input.Split();
            var inputMolecule = inputStrings[0];
            for (int i = 0; i < inputMolecule.Length; i++)
            {
                var c = inputMolecule[i];
                if (!char.IsDigit(c))
                {
                    List<int> ints = new List<int>();
                    int x = i + 1;
                    int value;
                    while(x < inputMolecule.Length && char.IsDigit(inputMolecule[x]))
                    {
                        ints.Add((int)char.GetNumericValue(inputMolecule[x]));
                        x++;
                    }
                    if (ints.Count > 0)
                    {
                        value = int.Parse(String.Concat(ints));
                        i += ints.Count;
                    }
                    else { value = 1; }
                    if (sourceMolecules.ContainsKey(c)) 
                    {
                        sourceMolecules[c] = value + sourceMolecules[c];
                    }
                    else
                    {
                        sourceMolecules.Add(c, value);
                    }
                } 
            }
        }
    }
}
