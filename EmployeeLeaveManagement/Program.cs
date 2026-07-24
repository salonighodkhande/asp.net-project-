using System;

class Customer
{
    public int CustomerId;
    public string? Name;
    public string? Email;
    public string? Password;
}

class Program
{
    static void Main()
    {
        Customer c = new Customer();

        // Registration
        Console.WriteLine("===== Customer Registration =====");

        Console.Write("Enter Customer ID: ");
        c.CustomerId = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Name: ");
        c.Name = Console.ReadLine();

        Console.Write("Enter Email: ");
        c.Email = Console.ReadLine();

        Console.Write("Enter Password: ");
        c.Password = Console.ReadLine();

        Console.WriteLine("\nRegistration Successful!");

        // Login
        Console.WriteLine("\n===== Customer Login =====");

        int attempts = 3;
        bool loginSuccess = false;

        while (attempts > 0)
        {
            Console.Write("Enter Email: ");
            string? email = Console.ReadLine();

            Console.Write("Enter Password: ");
            string? password = Console.ReadLine();

            if (email == c.Email && password == c.Password)
            {
                Console.WriteLine("\nWelcome " + c.Name);
                loginSuccess = true;
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

        if (!loginSuccess)
        {
            Console.WriteLine("\nAccount Locked");
        }
    }
}