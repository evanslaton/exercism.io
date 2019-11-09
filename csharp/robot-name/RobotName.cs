using System;
using System.Collections.Generic;

public class Robot
{
    private static char[] LETTERS = {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};
    private static int NUMBER_UPPER_LIMIT = 999;
    private static HashSet<string> robotNames = new HashSet<string>();
    public string name;

    public string Name
    {
        get
        {
            return name;
        }
        set
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
            newName = GetTwoLetters() + GetThreeDigits();
        
        } while (newName == Name || robotNames.Contains(newName));
        robotNames.Remove(Name);
        robotNames.Add(newName);
        Name = newName;
    }

    private static string GetTwoLetters()
    {
        Random random = new Random();
        int firstNumber = random.Next(0, LETTERS.Length);
        int secondNumber = random.Next(0, LETTERS.Length);
        return LETTERS[firstNumber].ToString() + LETTERS[secondNumber].ToString();
    }

    private static string GetThreeDigits() 
    {
        Random random = new Random();
        int randomNumber = random.Next(0, NUMBER_UPPER_LIMIT);
        string randomNumberAsString;
        if (randomNumber < 10) 
            randomNumberAsString = "00" + randomNumber;
        else if (randomNumber < 100) 
            randomNumberAsString = "0" + randomNumber;
        else 
            randomNumberAsString = randomNumber.ToString();
        return randomNumberAsString;
    }
}