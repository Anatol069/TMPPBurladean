public class Automobile
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public string Engine { get; set; }
    public string Color { get; set; }
    public string Features { get; set; }

    public void ShowInfo()
    {
        Console.WriteLine($" {Brand} {Model} - Engine: {Engine}, Color: {Color}, Features: {Features}");
    }
}
