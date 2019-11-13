using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using System.Linq;

public static class ParallelLetterFrequency
{
    public static Dictionary<char, int> Calculate(IEnumerable<string> texts)
    {
        ConcurrentDictionary<char, int> frequency = new ConcurrentDictionary<char, int>();
        Parallel.ForEach(texts, text => GetFrequencies(text, frequency));
        return frequency.ToDictionary(letter => letter.Key, letter => letter.Value);
    }

    private static void GetFrequencies(string text, ConcurrentDictionary<char, int> frequency) 
    {
        Parallel.ForEach(text, character =>
        {
            if (Char.IsLetter(character))
                frequency.AddOrUpdate(Char.ToLower(character), 1, (key, value) => value + 1);
        });
    }
}