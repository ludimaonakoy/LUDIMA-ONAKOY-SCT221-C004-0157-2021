using System;

class Program
{
    static void Main()
    {
        int a = 5;
        int b = 10;

        Console.WriteLine($"Before swapping: a = {a}, b = {b}");

        // Call the Swap function to swap the values
        Swap(ref a, ref b);

        Console.WriteLine($"After swapping: a = {a}, b = {b}");
    }

    static void Swap(ref int x, ref int y)
    {
        // Use a temporary variable to swap values
        int temp = x;
        x = y;
        y = temp;
    }
}

//NAME: LUDIMA ONAKOY JUNIOR
//REG-NUMBER: SCT221-C004-0157/2021
//CLASS : 3.2 EVENING JKUAT-CBD.