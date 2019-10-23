using System;
using System.Text.RegularExpressions;

public class PhoneNumber
{
    private static int MAX_LENGTH = 11;
    
    public static string Clean(string phoneNumber)
    {
        // Removes special characters
        phoneNumber = Regex.Replace(phoneNumber, @"[^\d]", "");

        // Validates phone number
        Match match = Regex.Match(phoneNumber, @"^1?(2|3|4|5|6|7|8|9)\d{2}(2|3|4|5|6|7|8|9)\d{6}$"); 

        if (match.Success)
        {
            // If the country code is included, remove it before returning
            return phoneNumber.Length == MAX_LENGTH ? phoneNumber.Substring(1) : phoneNumber;
        }
        else
        {
            throw new ArgumentException();
        }
    }
}