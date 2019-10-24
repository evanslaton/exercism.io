using System;

public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span) 
    {
        if (span == 0) return 1;
        if (span > digits.Length || span < 0) throw new ArgumentException();

        long largestProduct = Int64.MinValue;
        for (int i = 0; i <= digits.Length - span; i++)
        {
            largestProduct = Math.Max(largestProduct, GetProductOfSpan(digits, span, i));
        }
        return largestProduct;
    }

    private static long GetProductOfSpan(string digits, int span, int startingIndex)
    {
        long product = 1;
        int number;
        for (int i = startingIndex; i < startingIndex + span; i++)
        {
            if (Int32.TryParse(digits[i].ToString(), out number)) 
                product *= number;
            else 
                throw new ArgumentException();
        }
        return product;
    }
}