namespace CarSingleton
{
    public class Car
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }

        public Car(string model, string color, int year)
        {
            Model = model;
            Color = color;
            Year = year;
        }

        public override string ToString()
        {
            return $"{Year} {Color} {Model}";
        }
    }
}