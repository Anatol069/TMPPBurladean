using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class TrackOrderCommand : IOrderCommand
    {
        private readonly DeliverySystem _system;

        public TrackOrderCommand(DeliverySystem system)
        {
            _system = system;
        }

        public void Execute()
        {
            _system.TrackOrder();
        }
    }
}
