using System;

public class Vehicle
{
    public int VehicleId { get; set; }
    public string VehicleName { get; set; }
    public string VehicleType { get; set; }
    public string Brand { get; set; }
    public double Price { get; set; }
    public int Year { get; set; }

   
    public Vehicle(int vehicleId, string vehicleName, string vehicleType,
                   string brand, double price, int year)
    {
        VehicleId = vehicleId;
        VehicleName = vehicleName;
        VehicleType = vehicleType;
        Brand = brand;
        Price = price;
        Year = year;
    }
}