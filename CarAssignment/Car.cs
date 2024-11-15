using System;
using System.Collections.Generic;

public class Car
{
    public string Name = "KirmiziAraba";
    public string[] Seats = { "Front", "Back1", "Back2" };
    public string[] Tires = { "Summer", "Normal", "Winter" };
    public string[] Seasons = { "Summer", "Winter", "Spring", "Autumn" };
    public string PreferredTireType;

    public Car(string preferredTireType)
    {
        PreferredTireType = preferredTireType;
    }

    public void TireChange(string season)
    {
        if (season == "Summer")
        {
            PreferredTireType = "Summer";
            Console.WriteLine("Changed to Summer tires");
        }
        else if (season == "Winter")
        {
            PreferredTireType = "Winter";
            Console.WriteLine("Changed to Winter tires");
        }
        else if (season == "Spring" || season == "Autumn")
        {
            PreferredTireType = "Normal";
            Console.WriteLine("Changed to Normal tires");
        }
        else
        {
            Console.WriteLine("Invalid season provided");
        }
    }

    public void DisplayCarFeatures()
    {
        Console.WriteLine($"Car Name: {Name}");
        Console.WriteLine("Seats:");
        foreach (var seat in Seats)
        {
            Console.WriteLine($"Seat: {seat}");
        }

        Console.WriteLine("--- Available Tires ---");
        foreach (var tire in Tires)
        {
            Console.WriteLine(tire);
        }

        Console.WriteLine($"Preferred Tire Type: {PreferredTireType}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        var car = new Car("Normal");

        car.DisplayCarFeatures();

        car.TireChange("Summer");
        car.DisplayCarFeatures();

        car.TireChange("Winter");
        car.DisplayCarFeatures();
    }
}
