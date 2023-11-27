using System;

class Program
{
    static void Main()
    {
        // Create an instance of the Random class
        Random random = new Random();

        // Generate a random number between -10 and 10
        int n = random.Next(-10, 11);

        // Check if the number is positive or negative and print the result
        if (n > 0)
        {
            Console.WriteLine($"The number {n} is positive.");
        }
        else if (n < 0)
        {
            Console.WriteLine($"The number {n} is negative.");
        }
        else
        {
            Console.WriteLine("The number is zero.");
        }
    }
}

//NAME: LUDIMA ONAKOY JUNIOR
//REG-NUMBER: SCT221-C004-0157/2021
//CLASS : 3.2 EVENING JKUAT-CBD.