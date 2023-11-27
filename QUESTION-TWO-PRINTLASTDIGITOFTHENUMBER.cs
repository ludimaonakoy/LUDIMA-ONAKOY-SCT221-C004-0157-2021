using System;

class Program
{
    static void Main()
    {
        // Create an instance of the Random class
        Random random = new Random();

        // Generate a random number
        int n = random.Next();

        // Extract the last digit of the number
        int lastDigit = n % 10;

        // Print the last digit
        Console.WriteLine($"The last digit of {n} is {lastDigit}.");
    }
}

//NAME: LUDIMA ONAKOY JUNIOR
//REG-NUMBER: SCT221-C004-0157/2021
//CLASS : 3.2 EVENING JKUAT-CBD.