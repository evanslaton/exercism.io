using System;
using System.Collections.Generic;

public static class ProteinTranslation
{
    private static Dictionary<string, string> translator = new Dictionary<string, string>
        {
            {"AUG", "Methionine"},
            {"UUU", "Phenylalanine"},
            {"UUC", "Phenylalanine"},
            {"UUA", "Leucine"},
            {"UUG", "Leucine"},
            {"UCU", "Serine"},
            {"UCC", "Serine"},
            {"UCA", "Serine"},
            {"UCG", "Serine"},
            {"UAU", "Tyrosine"},
            {"UAC", "Tyrosine"},
            {"UGU", "Cysteine"},
            {"UGC", "Cysteine"},
            {"UGG", "Tryptophan"},
            {"UAA", "STOP"},
            {"UAG", "STOP"},
            {"UGA", "STOP"}
        };

    public static string[] Proteins(string strand)
    {
        int CODON_LENGTH = 3;
        List<string> proteins = new List<string>();
        string codon, protein;
        for (int i = 0; i < strand.Length; i += CODON_LENGTH)
        {
            codon = strand.Substring(i, CODON_LENGTH);
            protein = translator[codon];
            if (protein.Equals("STOP")) break;
            proteins.Add(protein);
        }
        return proteins.ToArray();
    }
}