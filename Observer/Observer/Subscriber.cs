using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Observer
{
    public class Subscriber : ISubscriber
    {
        private string _name;

        public Subscriber(string name)
        {
            _name = name;
        }

        public void Update(string videoTitle)
        {
            Console.WriteLine($" {_name} a fost notificat despre videoclipul: {videoTitle}");
        }
    }
}

