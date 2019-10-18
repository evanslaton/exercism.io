using System;
using System.Collections.Generic;

public static class Pangram
{
    private static HashSet<char> LETTERS = new HashSet<char>(new char[] {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'});

    public static bool IsPangram(string input)
    {
        HashSet<char> uniqueChars = new HashSet<char>();

        for (int i = 0; i < input.Length; i++) 
        {
            if (Pangram.LETTERS.Contains(Char.ToLower(input[i])))
            {
                uniqueChars.Add(Char.ToLower(input[i]));
            }
        }

        return uniqueChars.Count == Pangram.LETTERS.Count ? true : false;
    }
}
