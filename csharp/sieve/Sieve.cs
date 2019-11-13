using System;
using System.Collections.Generic;

public static class Sieve
{
    public static int[] Primes(int limit)
    {
        if (limit <= 1) throw new ArgumentOutOfRangeException();
        List<int> primes = GetTwoToLimit(limit);
        for (int i = 0; i < primes.Count; i++)
            for (int j = i + 1; j < primes.Count; j++)
                if (primes[j] % primes[i] == 0) primes.RemoveAt(j);
        return primes.ToArray();
    }

    private static List<int> GetTwoToLimit(int limit)
    {
        int FIRST_PRIME = 2;
        List<int> numbersTwoToLimit = new List<int>();
        for (int i = FIRST_PRIME; i <= limit; i++) numbersTwoToLimit.Add(i);
        return numbersTwoToLimit;
    }
}