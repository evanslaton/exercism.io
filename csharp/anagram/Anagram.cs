using System;
using System.Collections.Generic;

public class Anagram
{
    public string BaseWord { get; private set; }
    private string SortedBaseWord { get; }

    public Anagram(string baseWord)
    {
        BaseWord = baseWord;
        SortedBaseWord = SortWord(baseWord);
    }

    public string[] FindAnagrams(string[] potentialMatches)
    {
        List<string> anagrams = new List<string>();
        foreach (string word in potentialMatches)
            if (isAnagram(word)) anagrams.Add(word);
        return anagrams.ToArray();
    }

    private bool isAnagram(string word)
    {
        if (BaseWord.Length != word.Length) return false;
        if (BaseWord.ToLower() == word.ToLower()) return false;

        string sortedWord = SortWord(word);
        for (int i = 0; i < SortedBaseWord.Length; i++)
            if (SortedBaseWord[i] != sortedWord[i]) return false;
        return true;
    }

    private string SortWord(string word)
    {
        char[] characters = word.ToLower().ToCharArray();
        Array.Sort(characters);
        return new string(characters);
    }
}