using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    private List<int> AllScores;

    public HighScores(List<int> list)
    {
        AllScores = list;
    }

    public List<int> Scores() => AllScores;

    public int Latest() => AllScores[AllScores.Count - 1];

    public int PersonalBest()
    {
        int bestScore = Int32.MinValue;
        foreach (int score in AllScores)
        {
            if (score > bestScore) bestScore = score;
        }
        return bestScore;
    }

    public List<int> PersonalTopThree()
    {
        int[] topThreeScores = {Int32.MinValue, Int32.MinValue, Int32.MinValue};
        foreach (int score in AllScores)
        {
            if (score >= topThreeScores[0])
            {
                topThreeScores[2] = topThreeScores[1];
                topThreeScores[1] = topThreeScores[0];
                topThreeScores[0] = score;
            }
            else if (score >= topThreeScores[1])
            {
                topThreeScores[2] = topThreeScores[1];
                topThreeScores[1] = score;
            }
            else if (score >= topThreeScores[2])
            {
                topThreeScores[2] = score;
            }
        }

        List<int> output = new List<int>();
        for (int i = 0; i < AllScores.Count && i < 3; i++)
        {
            output.Add(topThreeScores[i]);
        }

        return output;
    }
}