using System;

class Program
{
    static void Main()
    {
        int minInt = int.MinValue;    // 32-bit integer minimum
        int maxInt = int.MaxValue;    // 32-bit integer maximum
        Console.WriteLine($"int range: {minInt} to {maxInt}");

        long minLong = long.MinValue; // 64-bit integer minimum
        long maxLong = long.MaxValue; // 64-bit integer maximum
        Console.WriteLine($"long range: {minLong} to {maxLong}");

        double minDouble = double.MinValue; // 64-bit floating-point minimum
        double maxDouble = double.MaxValue; // 64-bit floating-point maximum
        Console.WriteLine($"double range: {minDouble} to {maxDouble}");

        string minString = "";        // Empty string example
        Console.WriteLine($"Minimum string length: {minString.Length}");

        char minChar = char.MinValue; // Smallest Unicode character
        char maxChar = char.MaxValue; // Largest Unicode character
        Console.WriteLine($"char range: {(int)minChar} to {(int)maxChar}");
    }
}