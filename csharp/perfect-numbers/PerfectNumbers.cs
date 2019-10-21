using System;
using System.Collections.Generic;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        if (number < 1) throw new ArgumentOutOfRangeException();
        HashSet<int> factors = new HashSet<int>();
        if (number != 1) factors.Add(1);

        for (int i = 2; i <= number / 2; i++) 
        {
            if (number % i == 0) factors.Add(i);
        }

        int aliquotSum = 0;
        foreach(int factor in factors)
            aliquotSum += factor;

        if (aliquotSum == number) 
            return Classification.Perfect;
        else if (aliquotSum > number) 
            return Classification.Abundant;
        else 
            return Classification.Deficient;
    }
}
