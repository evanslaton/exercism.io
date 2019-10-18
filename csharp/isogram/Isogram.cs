using System;
using System.Collections.Generic;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        HashSet<char> uniqueChars = new HashSet<char>();
        int spacesAndUnderscoreCount = 0;

        for (int i = 0; i < word.Length; i++) {
            if (word[i] != ' ' && word[i] != '-')
            {
                uniqueChars.Add(Char.ToLower(word[i]));
            }
            else
            {
                spacesAndUnderscoreCount++;
            }
        }

        return word.Length == uniqueChars.Count + spacesAndUnderscoreCount ? true : false;
    }
}
