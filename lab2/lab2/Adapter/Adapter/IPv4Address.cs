using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
      public class IPv4Address :IIPAddress
    {
        //campul pt stocarea adresei ipv4
        private string _address;

        public IPv4Address()
        {}
        //primeste o adresa si o stocheaza in ipv4
        public IPv4Address(string address)
        {
            _address = address;
        }
        //returneaza adresa stocata
        public string GetAddress()
        {
            return _address;
        }

        
    }
}
