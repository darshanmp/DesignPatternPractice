using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    interface IVisitor
    {
        double CalcTax(Necessity necessity);
        double CalcTax(Alcohol alcohol);
        double CalcTax(Tobacco tobacco);
    }

    class TaxVisitor : IVisitor
    {
        public double CalcTax(Tobacco tobacco)
        {
            Console.WriteLine("Tax vistor : tob");
            return tobacco.price * 0.34;
        }

        public double CalcTax(Alcohol alcohol)
        {
            Console.WriteLine("Tax vistor : alcohol");
            return alcohol.price * 0.50;
        }

        public double CalcTax(Necessity necessity)
        {
            Console.WriteLine("Tax vistor : milk");
            return necessity.price * 0.10;
        }
    }

    class HolidayTaxVisitor : IVisitor
    {
        public double CalcTax(Tobacco tobacco)
        {
            return tobacco.price * 0.30;
        }

        public double CalcTax(Alcohol alcohol)
        {
            return alcohol.price * 0.40;
        }

        public double CalcTax(Necessity necessity)
        {
            return necessity.price * 0.05;
        }
    }

    interface IVisitable
    {
        double accept(IVisitor visit);
    }

    class Tobacco :IVisitable
    {
        public double price { get; set; }
        public Tobacco(double item)
        {
            price = item;
        }

        public double accept(IVisitor visit)
        {
            return visit.CalcTax(this);
        }
    }

    class Alcohol : IVisitable
    {
        public double price { get; set; }
        public Alcohol(double item)
        {
            price = item;
        }

        public double accept(IVisitor visit)
        {
            return visit.CalcTax(this);
        }
    }

    class Necessity : IVisitable
    {
        public double price { get; set; }
        public Necessity(double item)
        {
            price = item;
        }

        public double accept(IVisitor visit)
        {
            return visit.CalcTax(this);
        }
    } 

    //class Visitor
    //{
    //    static void Main(string[] args)
    //    {
    //        Necessity milk = new Necessity(2.75);
    //        Tobacco tob = new Tobacco(10);
    //        Alcohol alc = new Alcohol(20);

    //        Console.WriteLine(milk.accept(new TaxVisitor()));
    //        Console.WriteLine(tob.accept(new TaxVisitor()));
    //        Console.WriteLine(alc.accept(new TaxVisitor()));

    //        Console.WriteLine(milk.accept(new HolidayTaxVisitor()));
    //        Console.WriteLine(tob.accept(new HolidayTaxVisitor()));
    //        Console.WriteLine(alc.accept(new HolidayTaxVisitor()));

    //    }
    //}
}
