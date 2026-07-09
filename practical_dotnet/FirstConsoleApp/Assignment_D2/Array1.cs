using System;

class Program
{
    static void Main()
    {
        Array2.run();
        
        int[] sales = new int[6];
        int total = 0, highest, lowest;

        Console.WriteLine("Enter monthly sales of 6 employees:");

        // Input
        for (int i = 0; i < sales.Length; i++)
        {
            Console.Write("Employee " + (i + 1) + ": ");
            sales[i] = Convert.ToInt32(Console.ReadLine());
        }

        highest = sales[0];
        lowest = sales[0];

        // Display and Calculate
        Console.WriteLine("\nMonthly Sales:");

        for (int i = 0; i < sales.Length; i++)
        {
            Console.WriteLine("Employee " + (i + 1) + ": ₹" + sales[i]);

            total += sales[i];

            if (sales[i] > highest)
                highest = sales[i];

            if (sales[i] < lowest)
                lowest = sales[i];
        }

        double average = (double)total / sales.Length;

        Console.WriteLine("\nTotal Sales = ₹" + total);
        Console.WriteLine("Average Sales = ₹" + average);
        Console.WriteLine("Highest Sales = ₹" + highest);
        Console.WriteLine("Lowest Sales = ₹" + lowest);
    }

}