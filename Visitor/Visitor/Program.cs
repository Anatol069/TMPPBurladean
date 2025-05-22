using System;

namespace Visitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IProduct laptop = new Laptop();
            IProduct smartphone = new Smartphone();
            IProduct tablet = new Tablet();

            DiscountVisitor discount = new DiscountVisitor();

            laptop.Accept(discount);
            Console.WriteLine(discount.FinalMessage);

            smartphone.Accept(discount);
            Console.WriteLine(discount.FinalMessage);

            tablet.Accept(discount);
            Console.WriteLine(discount.FinalMessage);


            Console.ReadLine();
        }
    }
}
