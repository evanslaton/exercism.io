using System;
using System.Collections.Generic;

public static class ScrabbleScore
{
    private static char[] ONE_POINT_LETTERS = {'A', 'E', 'I', 'O', 'U', 'L', 'N', 'R', 'S', 'T'};
    private static char[] TWO_POINT_LETTERS = {'D', 'G'};
    private static char[] THREE_POINT_LETTERS = {'B', 'C', 'M', 'P'};
    private static char[] FOUR_POINT_LETTERS = {'F', 'H', 'V', 'W', 'Y'};
    private static char[] FIVE_POINT_LETTERS = {'K'};
    private static char[] EIGHT_POINT_LETTERS = {'J', 'X'};
    private static char[] TEN_POINT_LETTERS = {'Q', 'Z'};
    
    public static int Score(string input)
    {
        int score = 0;
        Dictionary<char, int> letterValues = ScrabbleScore.PopulateLetterValues();
        foreach(char letter in input.ToUpper())
            score += letterValues[letter];
        return score;
    }

    public static Dictionary<char, int> PopulateLetterValues()
    {
        Dictionary<char, int> letterValues = new Dictionary<char, int>();
        foreach (char letter in ScrabbleScore.ONE_POINT_LETTERS)
            letterValues.Add(letter, 1);
        foreach (char letter in ScrabbleScore.TWO_POINT_LETTERS)
            letterValues.Add(letter, 2);
        foreach (char letter in ScrabbleScore.THREE_POINT_LETTERS)
            letterValues.Add(letter, 3);
        foreach (char letter in ScrabbleScore.FOUR_POINT_LETTERS)
            letterValues.Add(letter, 4);
        foreach (char letter in ScrabbleScore.FIVE_POINT_LETTERS)
            letterValues.Add(letter, 5);
        foreach (char letter in ScrabbleScore.EIGHT_POINT_LETTERS)
            letterValues.Add(letter, 8);
        foreach (char letter in ScrabbleScore.TEN_POINT_LETTERS)
            letterValues.Add(letter, 10);
        return letterValues;
    }

}