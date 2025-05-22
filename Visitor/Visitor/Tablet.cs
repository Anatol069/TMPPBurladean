using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class Tablet : IProduct
    {
        public string Name = "iPad Air";
        public double Price = 3200;

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public string DisplayInfo()
        {
            return $"Tablet: {Name}, Pret: {Price} RON";
        }
    }
}

