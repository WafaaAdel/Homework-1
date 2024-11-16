using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the min number: ");
        int minNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter the max number: ");
        int maxNumber = int.Parse(Console.ReadLine());

        if (minNumber > maxNumber)
        {
            Console.WriteLine("Minimum number cannot be greater than maximum number."); return;
        }

        int[,] freqArray = new int[maxNumber - minNumber + 1, 2];

        for (int i = 0; i < freqArray.GetLength(0); i++)
        {
            freqArray[i, 0] = minNumber + i;
            freqArray[i, 1] = 0;
        }

        Random rand = new Random();

        for (int i = 0; i < 1000; i++)
        {
            int randomNumber = rand.Next(minNumber, maxNumber + 1);

            for (int j = 0; j < freqArray.GetLength(0); j++)
            {
                if (freqArray[j, 0] == randomNumber)
                {
                    freqArray[j, 1]++;
                    break;
                }
            }
        }

        Console.WriteLine("\nNumber:       Frequency:");
        for (int i = 0; i < freqArray.GetLength(0); i++)
        {
            Console.WriteLine($"{freqArray[i, 0]} \t\t\t {freqArray[i, 1]}");
        }
    }
}