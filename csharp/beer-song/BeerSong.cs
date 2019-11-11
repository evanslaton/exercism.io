using System;
using System.Text;

public static class BeerSong
{
    public static string Recite(int startBottles, int takeDown)
    {
        StringBuilder song = new StringBuilder();
        string plural;
        for (int i = 0; i < takeDown; i++)
        {
            if (startBottles > 1)
            {
                plural = startBottles - 1 == 1 ? "" : "s";
                song.Append($"{startBottles} bottles of beer on the wall, {startBottles} bottles of beer.\nTake one down and pass it around, {startBottles - 1} bottle{plural} of beer on the wall.");
            }
            else if (startBottles == 1)
            {
                song.Append($"1 bottle of beer on the wall, 1 bottle of beer.\nTake it down and pass it around, no more bottles of beer on the wall.");
            }
            else
            {
                song.Append("No more bottles of beer on the wall, no more bottles of beer.\nGo to the store and buy some more, 99 bottles of beer on the wall.");
            }
            startBottles--;
            if (i < takeDown - 1) song.Append("\n\n");
        }
        return song.ToString();
    }
}