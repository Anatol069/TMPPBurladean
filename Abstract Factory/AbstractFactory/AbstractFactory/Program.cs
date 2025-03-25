using System;

class Program
{
    static void Main(string[] args)
    {
        ICarFactory sedanFactory = new SedanFactory();
        CarClient sedanClient = new CarClient(sedanFactory);
        sedanClient.TestDrive();

        ICarFactory suvFactory = new SUVFactory();
        CarClient suvClient = new CarClient(suvFactory);
        suvClient.TestDrive();

        ICarFactory sportsCarFactory = new SportsCarFactory();
        CarClient sportsCarClient = new CarClient(sportsCarFactory);
        sportsCarClient.TestDrive();
    }
}
