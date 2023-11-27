using System;

class Program
{
    static void Main()
    {
        string input = "abcdef";
        int prefixLength = GetPrefixLength(input);

        Console.WriteLine($"The length of the prefix substring is: {prefixLength}");
    }

    static int GetPrefixLength(string input)
    {
        // Initialize the length to 0
        int length = 0;

        // Iterate through the characters of the string
        foreach (char c in input)
        {
            // Break the loop if the current character is not a letter
            if (!char.IsLetter(c))
            {
                break;
            }

            // Increment the length for each letter
            length++;
        }

        return length;
    }
}

//NAME: LUDIMA ONAKOY JUNIOR
//REG-NUMBER: SCT221-C004-0157/2021
//CLASS : 3.2 EVENING JKUAT-CBD.