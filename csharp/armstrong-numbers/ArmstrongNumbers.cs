using System;
using System.Collections.Generic;

public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {
        List<int> digits = GetDigits(number);
        int armstrongNumber = CalculateArmstrongNumber(GetDigits(number));
        return CalculateArmstrongNumber(GetDigits(number)) == number;
    }

    private static List<int> GetDigits(int number)
    {
        List<int> digits = new List<int>();
        while (number >= 1) 
        {
          digits.Add(number % 10);
          number /= 10;
        }  
        return digits;
    }

    private static int CalculateArmstrongNumber(List<int> digits)
    {
        int sum = 0;
        foreach (int digit in digits)
            sum += (int)Math.Pow(digit, digits.Count);
        return sum;
    }
}