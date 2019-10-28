using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    private List<int> AllScores;

    public HighScores(List<int> list) { AllScores = list; }

    public List<int> Scores() => AllScores;

    public int Latest() => AllScores[AllScores.Count - 1];

    public int PersonalBest() => AllScores.Max();

    public List<int> PersonalTopThree() => AllScores.OrderByDescending(score => score).Take(3).ToList();
}