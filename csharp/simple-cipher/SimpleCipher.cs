using System;
using System.Text;
using System.Collections.Generic;
using System.Diagnostics;

public class SimpleCipher
{
    private static Dictionary<char, int> LETTERS_TO_NUMBERS = new Dictionary<char, int>
    {
        {'a', 0},{'b', 1},{'c', 2},{'d', 3},{'e', 4},{'f', 5},{'g', 6},{'h', 7},{'i', 8},{'j', 9},
        {'k',10},{'l',11},{'m',12},{'n',13},{'o',14},{'p',15},{'q',16},{'r',17},{'s',18},{'t',19},
        {'u',20},{'v',21},{'w',22},{'x',23},{'y',24},{'z',25}
    };
    private static Dictionary<int, char> NUMBERS_TO_LETTERS = new Dictionary<int, char>
    {
        {0, 'a'},{1, 'b'},{2, 'c'},{3, 'd'},{4, 'e'},{5, 'f'},{6, 'g'},{7, 'h'},{8, 'i'},{9, 'j'},
        {10,'k'},{11,'l'},{12,'m'},{13,'n'},{14,'o'},{15,'p'},{16,'q'},{17,'r'},{18,'s'},{19,'t'},
        {20,'u'},{21,'v'},{22,'w'},{23,'x'},{24,'y'},{25,'z'}
    };
    private static string DEFAULT_KEY = "aaaaaaaaaaaaaaaaaa";

    public SimpleCipher()
    {
        Key = DEFAULT_KEY;
    }

    public SimpleCipher(string key)
    {
        Key = key;
    }
    
    public string Key { get; }

    public string Encode(string plaintext)
    {
        StackTrace stackTrace = new StackTrace();
        StringBuilder encodedText = new StringBuilder();
        char encodedLetter;
        int keyIndex = 0, letterAsNumber, shift;
        for (int i = 0; i < plaintext.Length; i++)
        {
            if (keyIndex > Key.Length - 1) keyIndex = 0;
            shift = LETTERS_TO_NUMBERS[Key[keyIndex]];
            if (stackTrace.GetFrame(1).GetMethod().Name == "Decode")
                letterAsNumber = GetLetterAsNumber(LETTERS_TO_NUMBERS[plaintext[i]] - shift);
            else
                letterAsNumber = GetLetterAsNumber(LETTERS_TO_NUMBERS[plaintext[i]] + shift);
            encodedLetter = NUMBERS_TO_LETTERS[letterAsNumber];
            encodedText.Append(encodedLetter);
            keyIndex++;
        }
        return encodedText.ToString();
    }

    public string Decode(string ciphertext) => Encode(ciphertext);

    private static int GetLetterAsNumber(int letterAsNumber)
    {
        if (letterAsNumber > NUMBERS_TO_LETTERS.Count - 1)
            return letterAsNumber -= NUMBERS_TO_LETTERS.Count;
        else if (letterAsNumber < 0)
            return letterAsNumber += NUMBERS_TO_LETTERS.Count;
        else
            return letterAsNumber;
    }
}