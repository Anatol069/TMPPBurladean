using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Command
{
    public class DeliverySystem
    {
        public void PlaceOrder()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Comanda a fost plasată.");
            Console.ResetColor();
        }

        public void CancelOrder()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Comanda a fost anulată.");
            Console.ResetColor();
        }

        public void TrackOrder()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Comanda este în drum spre tine.");
            Console.ResetColor();
        }

    }
}
