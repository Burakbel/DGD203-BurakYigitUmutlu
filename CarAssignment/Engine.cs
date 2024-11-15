using System;

public class KirmiziAraba
{
    public string Name  = "KirmiziAraba"; 
    public int Hp
    public float FuelAmount

    public KirmiziAraba(int hp, float fuelAmount)
    {
        HP = hp;
        FuelAmount = fuelAmount;
    }

    public void DisplayFeatures()
    {
        Console.WriteLine($"Car Name: {Name}");
        Console.WriteLine($"Hp: {HP}");
        Console.WriteLine($"Fuel Amount: {FuelAmount} liters");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        var kirmiziAraba = new KirmiziAraba(100, 50);
        kirmiziAraba.DisplayFeatures();
    }
}
