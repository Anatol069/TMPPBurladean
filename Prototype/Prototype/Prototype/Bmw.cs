class BMW : Automobile
{
    public BMW(string model, string features) : base(model, features) { }

    public override Automobile Clone()
    {
        Console.WriteLine(" Se clonează BMW...");
        return new BMW(this.Model, this.Features);
    }
}
