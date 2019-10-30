using System;

public static class AllYourBase
{
    public static int[] Rebase(int inputBase, int[] inputDigits, int outputBase)
    {
        if (inputBase < 2 || outputBase < 2) throw new ArgumentException();
        int inputValue = ConvertToBase10(inputBase, inputDigits);
        int placeValue = 1, outputLength = 1;
        while (placeValue <= inputValue && placeValue * outputBase <= inputValue)
        {
            placeValue *= outputBase;
            outputLength++;
        }
        return  ConvertToOutputBase(placeValue, outputLength, outputBase, inputValue);
    }

    private static int ConvertToBase10(int inputBase, int[] inputDigits)
    {
        int inputValue = 0, power = 0;
        for (int i = inputDigits.Length - 1; i >= 0; i--)
        {
            if (inputDigits[i] < 0 || inputDigits[i] > inputBase - 1) throw new ArgumentException();
            inputValue += inputDigits[i] * (int)Math.Pow(inputBase, power++);
        }
        return inputValue;
    }

    private static int[] ConvertToOutputBase(int placeValue, int outputLength, int outputBase, int inputValue)
    {
        int[] output = new int[outputLength];
        for (int i = 0; i < output.Length; i++)
        {
            while (placeValue <= inputValue && placeValue > 0)
            {
                output[i]++;
                inputValue -= placeValue;
            }
            placeValue /= outputBase;
        }
        return output;
    }
}