using System;
using System.Collections.Generic;

public class Robot
{
    private const string LETTERS = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private const int NUMBER_UPPER_LIMIT = 999;
    private const int LEFT_PADDING = 3;
    private const char PADDING_CHAR = '0';
    private readonly static HashSet<string> robotNames = new HashSet<string>();
    private readonly static Random RANDOM = new Random();
    private string name;

    public string Name
    {
        get
        {
            return name;
        }
        private set
        {
            name = value;
        }
    }

    public Robot()
    {
        Reset();
    }

    public void Reset()
    {
       string newName;
        do
        {
            newName = $"{GetTwoLetters()}{GetThreeDigits()}";
        
        } while (newName == Name || robotNames.Contains(newName));
        robotNames.Remove(Name);
        robotNames.Add(newName);
        Name = newName;
    }

    private static string GetTwoLetters()
    {
        int firstNumber = RANDOM.Next(0, LETTERS.Length);
        int secondNumber = RANDOM.Next(0, LETTERS.Length);
        return LETTERS[firstNumber].ToString() + LETTERS[secondNumber].ToString();
    }

    private static string GetThreeDigits() 
    {
        return RANDOM.Next(0, NUMBER_UPPER_LIMIT)
            .ToString()
            .PadLeft(LEFT_PADDING, PADDING_CHAR);
    }
}