using System;

public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span) 
    {
        if (span == 0) return 1;
        if (span > digits.Length || span < 0) throw new ArgumentException();

        int[] numbers = ConvertStringToIntArray(digits);
        long largestProduct = Int64.MinValue;
        for (int i = 0; i <= numbers.Length - span; i++)
        {
            largestProduct = Math.Max(largestProduct, GetProductOfSpan(numbers, span, i));
        }
        return largestProduct;
    }

    private static int[] ConvertStringToIntArray(string digits)
    {
        int[] output = new int[digits.Length];
        int number;
        for (int i = 0; i < digits.Length; i++)
        {
            if (Int32.TryParse(digits[i].ToString(), out number)) 
                output[i] = number;
            else 
                throw new ArgumentException();
        }
        return output;
    }

    private static long GetProductOfSpan(int[] numbers, int span, int startingIndex)
    {
        long product = 1;
        for (int i = startingIndex; i < startingIndex + span; i++)
        {
           product *= numbers[i];
        }
        return product;
    }
}