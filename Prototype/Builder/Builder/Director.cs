public class Director
{
    public Automobile BuildTeslaModelS()
    {
        return new AutomobileBuilder()
            .SetBrand("Tesla")
            .SetModel("Model S")
            .SetEngine("Electric")
            .SetColor("Red")
            .SetFeatures("Autopilot, Long Range, FSD")
            .Build();
    }

    public Automobile BuildBMWM5()
    {
        return new AutomobileBuilder()
            .SetBrand("BMW")
            .SetModel("M5")
            .SetEngine("V8")
            .SetColor("Blue")
            .SetFeatures("M Mode, Adaptive Suspension, Sports Package")
            .Build();
    }
}
