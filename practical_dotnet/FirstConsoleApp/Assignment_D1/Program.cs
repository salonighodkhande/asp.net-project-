
// Program 1
using System;

class Program
{
    static void Main()
    {
        int qualityCheck = 0;
        int priorityShipment = 0;
        int normalProcessing = 0;

        for (int packageId = 1001; packageId <= 1010; packageId++)
        {
            if (packageId % 4 == 0)
            {
                Console.WriteLine("Package ID: " + packageId + " - Quality Check Required");
                qualityCheck++;
            }
            else if (packageId % 5 == 0)
            {
                Console.WriteLine("Package ID: " + packageId + " - Priority Shipment");
                priorityShipment++;
            }
            else
            {
                Console.WriteLine("Package ID: " + packageId + " - Normal Processing");
                normalProcessing++;
            }
        }

        Console.WriteLine("\nTotal Packages Processed: 10");
        Console.WriteLine("Quality Check Required: " + qualityCheck);
        Console.WriteLine("Priority Shipments: " + priorityShipment);
        Console.WriteLine("Normal Processing: " + normalProcessing);

        Light();
    }
// Problem 2 
    public static void Light()
    {
        int power, totalPower = 0;
        int maintenance = 0;
        int normal = 0;
        int efficient = 0;

        for (int light = 1; light <= 10; light++)
        {
            power = 80 + (light * 5);
            totalPower += power;

            Console.Write("Street Light " + light + " : " + power + " W - ");

            if (power > 180)
            {
                Console.WriteLine("Maintenance Required");
                maintenance++;
            }
            else if (power >= 140 && power <= 180)
            {
                Console.WriteLine("Normal Operation");
                normal++;
            }
            else
            {
                Console.WriteLine("Energy Efficient");
                efficient++;
            }
        }

        double average = (double)totalPower / 10;

        Console.WriteLine("\nTotal Power Consumed = " + totalPower + " W");
        Console.WriteLine("Average Power Consumption = " + average + " W");
        Console.WriteLine("Maintenance Required Lights = " + maintenance);
        Console.WriteLine("Normal Operation Lights = " + normal);
        Console.WriteLine("Energy Efficient Lights = " + efficient);
    }
}
