using System;

public class Program
{
    public static void Main()
    {
        int number = AskForNumberInRange("Enter a number between 0 and 5: ", 0, 5);
        Console.WriteLine("You entered: " + number);

        int[] originalArray = new int[number];
        for (int i = 0; i < number; i++)
        {
            originalArray[i] = AskForNumber("Enter an integer: ");
        }

        int[] replicatedArray = ReplicateArray(originalArray);
        Console.WriteLine("Replicated array: " + string.Join(", ", replicatedArray));
    }

    public static int AskForNumber(string text)
    {
        Console.Write(text);
        string response = Console.ReadLine();
        int number = int.Parse(response);
        return number;
    }

    public static int AskForNumberInRange(string text, int min, int max)
    {
        int number;
        do
        {
            number = AskForNumber(text);
        } while (number < min || number > max);

        return number;
    }

    public static int[] ReplicateArray(int[] original)
    {
        int[] replicatedArray = new int[original.Length];
        for (int i = 0; i < original.Length; i++)
        {
            replicatedArray[i] = original[i];
        }

        return replicatedArray;
    }
}
