using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
       static void Main()
{
    Customer customer = new Customer();

    Console.WriteLine("===== CUSTOMER REGISTRATION =====");

    Console.Write("Enter Customer ID: ");
    customer.CustomerId = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter Customer Name: ");
    customer.Name = Console.ReadLine();

    Console.Write("Enter Email: ");
    customer.Email = Console.ReadLine();

    Console.Write("Enter Password: ");
    customer.Password = Console.ReadLine();

    Console.WriteLine("\nRegistration Successful!");

    Console.WriteLine("\n===== CUSTOMER LOGIN =====");

    int attempts = 3;
    bool isLogin = false;

    while (attempts > 0)
    {
        Console.Write("Enter Email: ");
        string? email = Console.ReadLine();

        Console.Write("Enter Password: ");
        string? password = Console.ReadLine();

        if (email == customer.Email && password == customer.Password)
        {
            Console.WriteLine("\nWelcome " + customer.Name);
            isLogin = true;
            break;
        }
        else
        {
            attempts--;

            if (attempts > 0)
            {
                Console.WriteLine("Invalid Email or Password.");
                Console.WriteLine("Attempts Left: " + attempts);
            }
        }
    }

    if (!isLogin)
    {
        Console.WriteLine("\nAccount Locked");
    }
}
    }
}
