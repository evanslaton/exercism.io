using System;
using System.Text;

public static class RnaTranscription
{
    public static string ToRna(string nucleotides)
    {
        StringBuilder sb = new StringBuilder();

        foreach (char nucleotide in nucleotides)
        {
            switch (nucleotide)
            {
                case 'A':
                    sb.Append('U');
                    break;
                case 'C':
                    sb.Append('G');
                    break;
                case 'G':
                    sb.Append('C');
                    break;
                case 'T':
                    sb.Append('A');
                    break;
            }
        }

        return sb.ToString();
    }
}