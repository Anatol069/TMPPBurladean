using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public interface IVisitor
    {
        void Visit(Laptop laptop);
        void Visit(Smartphone smartphone);
        void Visit(Tablet tablet);
    }
}

