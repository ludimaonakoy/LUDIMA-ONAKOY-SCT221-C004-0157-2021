using System;

class Program
{
    static void Main()
    {
        PrintStringInReverse("Hello, World!");
    }

    static void PrintStringInReverse(string input)
    {
        // Convert the string to a char array
        char[] charArray = input.ToCharArray();

        // Reverse the char array
        Array.Reverse(charArray);

        // Convert the char array back to a string
        string reversedString = new string(charArray);

        // Print the reversed string
        Console.WriteLine(reversedString);
    }
}

//NAME: LUDIMA ONAKOY JUNIOR
//REG-NUMBER: SCT221-C004-0157/2021
//CLASS : 3.2 EVENING JKUAT-CBD.