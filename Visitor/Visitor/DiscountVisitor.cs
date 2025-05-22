using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Visitor
{
    public class DiscountVisitor : IVisitor
    {
        public string FinalMessage = "";

        public void Visit(Laptop laptop)
        {
            double discount = laptop.Price * 0.10;
            double finalPrice = laptop.Price - discount;
            FinalMessage = $"Produs: {laptop.Name}\nPret initial: {laptop.Price} RON\nReducere: {discount} RON\nPret final: {finalPrice} RON\n";
        }

        public void Visit(Smartphone smartphone)
        {
            double discount = smartphone.Price * 0.05;
            double finalPrice = smartphone.Price - discount;
            FinalMessage = $"Produs: {smartphone.Name}\nPret initial: {smartphone.Price} RON\nReducere: {discount} RON\nPret final: {finalPrice} RON\n";
        }

        public void Visit(Tablet tablet)
        {
            double discount = tablet.Price * 0.08;
            double finalPrice = tablet.Price - discount;
            FinalMessage = $"Produs: {tablet.Name}\nPret initial: {tablet.Price} RON\nReducere: {discount} RON\nPret final: {finalPrice} RON\n";
        }
    }
}


