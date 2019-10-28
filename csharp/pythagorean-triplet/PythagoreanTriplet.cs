using System;
using System.Collections.Generic;

public static class PythagoreanTriplet
{
    public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
    {
        List<(int a, int b, int c)> output = new List<(int a, int b, int c)>();
        int a, b, c = 0;
        for (int n = 1; n < sum; n++) 
        {
            for (int m = n + 1; m < sum; m++)
            {
                //Euclid's Proof
                a = m*m - n*n;
                b = 2*m*n;
                c = m*m + n*n;

                if (a + b + c == sum && a < b) output.Add((a, b, c));
                else if (a + b + c == sum && a > b) output.Add((b, a, c));
            }

        }
        return output.ToArray();
    }
}