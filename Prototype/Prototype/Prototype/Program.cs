using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(" Crearea automobilelor originale...");

        Automobile originalTesla = new Tesla("Tesla Model S", "Electric, Autopilot, Long Range");
        Automobile originalBMW = new BMW("BMW M5", "Combustie, Motor V8, M Mode");

        originalTesla.ShowInfo();
        originalBMW.ShowInfo();

        Console.WriteLine("\n Clonarea automobilelor...");

        Automobile clonedTesla = originalTesla.Clone();
        Automobile clonedBMW = originalBMW.Clone();

        clonedTesla.ShowInfo();
        clonedBMW.ShowInfo();

        Console.WriteLine("Apăsați orice tastă pentru a ieși...");
        Console.ReadKey();
    }
}
