abstract class Automobile : ICloneableAutomobile
{
    public string Model { get; private set; }
    public string Features { get; private set; }

    public Automobile(string model, string features)
    {
        Model = model;
        Features = features;
    }

    public void ShowInfo()
    {
        Console.WriteLine($" {Model} - Caracteristici: {Features}");
    }

    public abstract Automobile Clone();
}
