using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            DeliverySystem system = new DeliverySystem();

            IOrderCommand place = new PlaceOrderCommand(system);
            IOrderCommand cancel = new CancelOrderCommand(system);
            IOrderCommand track = new TrackOrderCommand(system);

            OrderButton button = new OrderButton();

            button.SetCommand(place);
            button.Press();  // ✅

            button.SetCommand(track);
            button.Press();  // 🚚

            button.SetCommand(cancel);
            button.Press();  // ❌

            Console.ReadLine();
        }
    }
}
