using System;
using System.Collections.Generic;
using System.Linq;

public static class PrimeFactors
{
    public static long[] Factors(long number)
    {
        if (IsPrime(number)) return new long[0];
        if (number == 2) return new long[] {2};

        List<long> primeFactors = GetPrimeFactors(number);
        List<long> output = new List<long>();

        for (int i = 0; i < primeFactors.Count; i++)
        {
            if (number % primeFactors[i] == 0)
            {
                output.Add(primeFactors[i]);
                number /= primeFactors[i];
                i = -1;
            }
        }

        return output.ToArray();
    }

    private static List<long> GetPrimeFactors(long number) {
        List<long> factors = new List<long>();;
        long boundary = 1_000_000;
        for (long i = 2; i <= boundary; i++) { 
            if (number % i == 0)
                factors.Add(i);
        }

        return factors.ToList();
    }

    private static bool IsPrime(long number)
    {
        if (number <= 1 || number % 2 == 0) return false;
        if (number == 2) return true;

        int boundary = (int)Math.Sqrt(number);
        for (int i = 3; i <= boundary; i += 2)
            if (number % i == 0) return false;

        return true;        
    }
}