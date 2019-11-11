using System;
using System.Text;

public static class Proverb
{
    public static string[] Recite(string[] subjects)
    {
        string[] phrases = new string[subjects.Length];
        for (int i = 0; i < subjects.Length; i++)
        {
            if (i == subjects.Length - 1)
                phrases[i] = $"And all for the want of a {subjects[0]}.";
            else
                phrases[i] = $"For want of a {subjects[i]} the {subjects[i + 1]} was lost.";
        }
        return phrases;
    }
}