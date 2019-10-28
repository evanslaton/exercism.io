using System;
using System.Collections.Generic;

public static class PythagoreanTriplet
{
    public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
    {
        var output = new List<(int a, int b, int c)>();
        int c;
        for (int a = 1; a < sum; a++) 
        {
            for (int b = a + 1; b < sum; b++)
            {
                c = sum - a - b;
                if (a*a + b*b == c*c) output.Add((a, b, c));
            }
        }
        return output;
    }
}