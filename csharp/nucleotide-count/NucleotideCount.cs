using System;
using System.Collections.Generic;

public static class NucleotideCount
{
    private static char[] Nucleotides = {'A', 'C', 'G', 'T'};
    
    public static IDictionary<char, int> Count(string sequence)
    {
        Dictionary<char, int> nucleotideCounts = new Dictionary<char, int>();
        foreach (char nucleotide in Nucleotides)
            nucleotideCounts.Add(nucleotide, 0);

        foreach (char nucleotide in sequence)
        {
            if (!nucleotideCounts.ContainsKey(nucleotide)) throw new ArgumentException();
            nucleotideCounts[nucleotide] = nucleotideCounts[nucleotide] + 1;
        }

        return nucleotideCounts;
    }
}