using System;
using System.Text;

public static class Raindrops
{
    public static string Convert(int number)
    {
        StringBuilder answer = new StringBuilder();
        if (number % 3 == 0) answer.Append("Pling");
        if (number % 5 == 0) answer.Append("Plang");
        if (number % 7 == 0) answer.Append("Plong");
        return answer.Length == 0 ? number.ToString() : answer.ToString();
    }
}