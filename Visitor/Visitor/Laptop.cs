using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class Laptop : IProduct
    {
        public string Name = "Laptop ASUS";
        public double Price = 5000;

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public string DisplayInfo()
        {
            return $"Laptop: {Name}, Pret: {Price} RON";
        }
    }
}

