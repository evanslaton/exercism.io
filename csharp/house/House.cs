using System;
using System.Text;

public static class House
{
    private static string INTRO = "This is";
    private static string THAT = " that ";
    private static string THE = " the ";
    private static string[] NOUNS = {"house",
                                    "malt",
                                    "rat",
                                    "cat",
                                    "dog",
                                    "cow with the crumpled horn",
                                    "maiden all forlorn",
                                    "man all tattered and torn",
                                    "priest all shaven and shorn",
                                    "rooster that crowed in the morn",
                                    "farmer sowing his corn",
                                    "horse and the hound and the horn"};
    private static string[] VERBS = {"Jack built.",
                                    "lay in",
                                    "ate",
                                    "killed",
                                    "worried",
                                    "tossed",
                                    "milked",
                                    "kissed",
                                    "married",
                                    "woke",
                                    "kept",
                                    "belonged to"};

    public static string Recite(int verseNumber)
    {
        StringBuilder verse = new StringBuilder();
        verse.Append(INTRO);
        for (int i = verseNumber - 1; i >= 0; i--)
        {
            verse.Append(THE);
            verse.Append(NOUNS[i]);
            verse.Append(THAT);
            verse.Append(VERBS[i]);  
        }
        return verse.ToString();
    }

    public static string Recite(int startVerse, int endVerse)
    {
        StringBuilder verses = new StringBuilder();
        for (int i = startVerse; i <= endVerse; i++)
        {
            verses.Append(Recite(i));
            if (i != endVerse)
                verses.Append("\n");
        }
        return verses.ToString();
    }
}