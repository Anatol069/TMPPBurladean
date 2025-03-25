using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine(" Construirea automobilelor folosind Builder Pattern...\n");

        Director director = new Director();

        Automobile teslaModelS = director.BuildTeslaModelS();
        teslaModelS.ShowInfo();

        Automobile bmwM5 = director.BuildBMWM5();
        bmwM5.ShowInfo();

        Console.WriteLine("Apăsați orice tastă pentru a ieși...");
        Console.ReadKey();
    }
}
