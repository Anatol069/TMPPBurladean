public class AutomobileBuilder
{
    private Automobile _automobile;

    public AutomobileBuilder()
    {
        _automobile = new Automobile();
    }

    public AutomobileBuilder SetBrand(string brand)
    {
        _automobile.Brand = brand;
        return this;
    }

    public AutomobileBuilder SetModel(string model)
    {
        _automobile.Model = model;
        return this;
    }

    public AutomobileBuilder SetEngine(string engine)
    {
        _automobile.Engine = engine;
        return this;
    }

    public AutomobileBuilder SetColor(string color)
    {
        _automobile.Color = color;
        return this;
    }

    public AutomobileBuilder SetFeatures(string features)
    {
        _automobile.Features = features;
        return this;
    }

    public Automobile Build()
    {
        return _automobile;
    }
}

