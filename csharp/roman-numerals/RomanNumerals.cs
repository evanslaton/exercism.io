using System;
using System.Text;
using System.Collections.Generic;

public static class RomanNumeralExtension
{
    private static Dictionary<int, string> TRANSLATOR = new Dictionary<int, string>
    {
        {1, "I"}, {4, "IV"}, {5, "V"}, {9, "IX"}, {10, "X"},
        {40, "XL"}, {50, "L"}, {90, "XC"}, {100, "C"},
        {400, "CD"}, {500, "D"}, {900, "CM"}, {1000, "M"}
    };
    private static int[] VALUES = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

    public static string ToRoman(this int value)
    {
        StringBuilder romanNumeral = new StringBuilder();
        int index = 0;
        while (value > 0) 
        {
            if (VALUES[index] <= value)
            {
                romanNumeral.Append(TRANSLATOR[VALUES[index]]);
                value -= VALUES[index];
            }
            else
            {
                index++;
            }
        }
        return romanNumeral.ToString();
    }
}