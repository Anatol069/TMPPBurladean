class Tesla : Automobile
{
    public Tesla(string model, string features) : base(model, features) { }

    public override Automobile Clone()
    {
        Console.WriteLine(" Se clonează Tesla...");
        return new Tesla(this.Model, this.Features);
    }
}