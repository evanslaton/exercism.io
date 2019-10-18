using System;
using System.Text;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(Char.ToUpper(phrase[0]));

        for (int i = 1; i < phrase.Length - 1; i++)
        {
            if ((phrase[i] == ' ' || phrase[i] == '-' || phrase[i] == '_') && 
                (phrase[i + 1] != ' ' && phrase[i + 1] != '-' && phrase[i + 1] != '_'))
            {
                sb.Append(Char.ToUpper(phrase[i + 1]));
            }
        }

        return sb.ToString();
    }
}