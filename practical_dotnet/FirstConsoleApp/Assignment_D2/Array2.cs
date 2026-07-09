using System;
using System.Collections.Generic;

class Array2
{
    public static void run()
    {
        List<string> books = new List<string>()
        {
            "The Alchemist",
            "Wings of Fire",
            "Rich Dad Poor Dad",
            "Think and Grow Rich"
        };

        Console.WriteLine("Available Books:");
        foreach (string book in books)
        {
            Console.WriteLine(book);
        }

        books.Add("Atomic Habits");

        books.Remove("Rich Dad Poor Dad");

        Console.WriteLine("\nUpdated Book List:");
        foreach (string book in books)
        {
            Console.WriteLine(book);
        }

        Console.WriteLine("\nTotal Number of Books: " + books.Count);
    }
}