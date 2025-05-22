using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class Smartphone : IProduct
    {
        public string Name = "iPhone 14";
        public double Price = 4500;

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public string DisplayInfo()
        {
            return $"Smartphone: {Name}, Pret: {Price} RON";
        }
    }
}

