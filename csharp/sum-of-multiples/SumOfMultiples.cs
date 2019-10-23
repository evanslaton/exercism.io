using System;
using System.Collections.Generic;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        HashSet<int> uniqueMultiples = new HashSet<int>();

        foreach (int number in multiples)
        {
            if (number == 0) continue;

            for (int j = number; j < max; j++)
            {
                if (j % number == 0) uniqueMultiples.Add(j);
            }
        }

        int sumOfMultiples = 0;
        foreach (int number in uniqueMultiples) sumOfMultiples += number;

        return sumOfMultiples;
    }
}