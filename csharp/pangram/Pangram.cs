using System;
using System.Collections.Generic;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        char[] letters = new char[]{'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
        HashSet<char> lettersToCheckFor = new HashSet<char>(letters);
        HashSet<char> uniqueChars = new HashSet<char>();

        for (int i = 0; i < input.Length; i++) 
        {
            if (lettersToCheckFor.Contains(Char.ToLower(input[i])))
            {
                uniqueChars.Add(Char.ToLower(input[i]));
            }
        }
        return uniqueChars.Count == 26 ? true : false;
    }
}
