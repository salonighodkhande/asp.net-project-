using System;
using System.Collections.Generic;

public class VehicleManager
{
    List<Vehicle> vehicles = new List<Vehicle>();

    public void AddVehicle()
{
    Console.Write("Enter Vehicle ID: ");
    int id = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter Vehicle Name: ");
    string name = Console.ReadLine();

    Console.Write("Enter Vehicle Type (Car/Bike/Truck): ");
    string type = Console.ReadLine();

    Console.Write("Enter Brand: ");
    string brand = Console.ReadLine();

    Console.Write("Enter Price: ");
    double price = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter Manufacturing Year: ");
    int year = Convert.ToInt32(Console.ReadLine());

    Vehicle v = new Vehicle(id, name, type, brand, price, year);

    vehicles.Add(v);

    Console.WriteLine("\nVehicle Added Successfully!");
}

public void ViewVehicles()
{
    if (vehicles.Count == 0)
    {
        Console.WriteLine("No vehicles available.");
        return;
    }

    Console.WriteLine("\n---------------------------------------------------------------");
    Console.WriteLine("ID\tName\tBrand\tType\tPrice\t\tYear");
    Console.WriteLine("---------------------------------------------------------------");

    foreach (Vehicle v in vehicles)
    {
        Console.WriteLine($"{v.VehicleId}\t{v.VehicleName}\t{v.Brand}\t{v.VehicleType}\t{v.Price}\t{v.Year}");
    }
}

   public void SearchVehicle()
{
    Console.Write("Enter Vehicle ID to Search: ");
    int id = Convert.ToInt32(Console.ReadLine());

    foreach (Vehicle v in vehicles)
    {
        if (v.VehicleId == id)
        {
            Console.WriteLine("\nVehicle Found!");
            Console.WriteLine($"ID: {v.VehicleId}");
            Console.WriteLine($"Name: {v.VehicleName}");
            Console.WriteLine($"Brand: {v.Brand}");
            Console.WriteLine($"Type: {v.VehicleType}");
            Console.WriteLine($"Price: {v.Price}");
            Console.WriteLine($"Year: {v.Year}");
            return;
        }
    }

    Console.WriteLine("Vehicle not found.");
}

   public void UpdatePrice()
{
    Console.Write("Enter Vehicle ID: ");
    int id = Convert.ToInt32(Console.ReadLine());

    foreach (Vehicle v in vehicles)
    {
        if (v.VehicleId == id)
        {
            Console.Write("Enter New Price: ");
            v.Price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Price Updated Successfully!");
            return;
        }
    }

    Console.WriteLine("Vehicle ID does not exist.");
}   

     public void DeleteVehicle()
{
    Console.Write("Enter Vehicle ID: ");
    int id = Convert.ToInt32(Console.ReadLine());

    foreach (Vehicle v in vehicles)
    {
        if (v.VehicleId == id)
        {
            vehicles.Remove(v);
            Console.WriteLine("Vehicle Deleted Successfully!");
            return;
        }
    }

    Console.WriteLine("Vehicle not available.");
}  
    public void CalculateDiscount()
{
    Console.Write("Enter Vehicle ID: ");
    int id = Convert.ToInt32(Console.ReadLine());

    foreach (Vehicle v in vehicles)
    {
        if (v.VehicleId == id)
        {
            double discount = 0;

            switch (v.VehicleType.ToLower())
            {
                case "car":
                    discount = v.Price * 0.10;
                    break;

                case "bike":
                    discount = v.Price * 0.05;
                    break;

                case "truck":
                    discount = v.Price * 0.12;
                    break;
            }

            Console.WriteLine($"Vehicle Price : {v.Price}");
            Console.WriteLine($"Discount : {discount}");
            Console.WriteLine($"Final Price : {v.Price - discount}");
            return;
        }
    }

    Console.WriteLine("Vehicle not found.");
}
    public void ShowVehicleDetails()
{
    Console.Write("Enter Vehicle Type (Car/Bike/Truck): ");
    string type = Console.ReadLine().ToLower();

    switch (type)
    {
        case "car":
            Console.WriteLine("Car is a four wheeler.");
            Console.WriteLine("Suitable for family.");
            break;

        case "bike":
            Console.WriteLine("Bike is fuel efficient.");
            Console.WriteLine("Suitable for city rides.");
            break;

        case "truck":
            Console.WriteLine("Truck is used for transportation.");
            Console.WriteLine("Heavy load vehicle.");
            break;

        default:
            Console.WriteLine("Invalid Vehicle Type.");
            break;
    }
}
 }