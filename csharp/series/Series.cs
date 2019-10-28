using System;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        if (numbers.Length == 0 || sliceLength > numbers.Length || sliceLength < 1)
            throw new ArgumentException();

        string[] output = new string[numbers.Length - (sliceLength - 1)];
        for (int i = 0; i < numbers.Length - (sliceLength - 1); i++)
        {
            output[i] = numbers.Substring(i, sliceLength);
        }

        return output;
    }
}