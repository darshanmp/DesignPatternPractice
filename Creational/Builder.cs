using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Creational.Builder
{
    //Meal preparation in Mcdonalds by waiter
    interface IItem
    {
        double price();        
        string name();
        Packing packing();
    }

    class Burger : IItem
    {
        public virtual string name()
        {
            return "";
        }

        public Packing packing()
        {
            return new Wrap();
        }

        public virtual double price()
        {
            return 1;
        }
    }
    class VegBurger : Burger
    {
        public override double price()
        {
            return 2.2;
        }
        public override string name()
        {
            return "Veg Burger";
        }

    }
    class ChickenBurger : Burger
    {
        public override double price()
        {
            return 3.2;
        }
        public override string name()
        {
            return "Chicken Burger";
        }
    }

    interface Packing
    {
        string doPacking();
    }
    class Wrap : Packing
    {
        public string doPacking()
        {
            string t = "Wrap packing done";
            Console.WriteLine(t);
            return t;            
        }
    }
    class Bottle : Packing
    {
        public string doPacking()
        {
            string t = "Bottle packing done";
            Console.WriteLine(t);
            return t;
        }
    }

    class Soda : IItem
    {
        public virtual string name()
        {
            return "";
        }

        public Packing packing()
        {
            return new Bottle();
        }

        public virtual double price()
        {
            return 1;
        }
    }
    class Pepsi : Soda
    {
        public override double price()
        {
            return 1.2;
        }
        public override string name()
        {
            return "Pepsi";
        }

    }
    class CocaCola : Soda
    {
        public override double price()
        {
            return 1.4;
        }
        public override string name()
        {
            return "CocaCola";
        }
    }

    class Meal
    {
        List<IItem> itemLst = null;
        public Meal()
        {
            itemLst = new List<IItem>();
        }
        public void addItem(IItem item)
        {
            itemLst.Add(item);
        }
        public void removeItem(IItem item)
        {
            itemLst.Remove(item);
        }
        public List<IItem> getItems()
        {
            return itemLst;
        }
        public Double calcPrice()
        {
            var sum = itemLst.Sum(i => i.price());
            return (Double)sum; 
        }
    }

    class Manager
    {
        public Meal preparevegMeal()
        {
            Meal meal = new Meal();
            meal.addItem(new VegBurger());
            meal.addItem(new Pepsi());
            meal.calcPrice();
            return meal;
        }
        public Meal prepareNonVegMeal()
        {
            Meal meal = new Meal();
            meal.addItem(new ChickenBurger());
            meal.addItem(new CocaCola());
            return meal;            
        }
    }

    class BuilderDP
    {
        //public static void Main()
        //{
        //    Console.WriteLine("Prepare veg meal");
        //    Manager man = new Manager();

        //    Meal meal = man.preparevegMeal();
        //    meal.getItems().ForEach(c => { Console.WriteLine(c.name() + " : " +c.price()); });
        //    Console.WriteLine("Total price " + meal.calcPrice());

        //    Console.WriteLine();
        //    Console.WriteLine();
        //    Console.WriteLine("Prepare  non veg meal");
        //    Meal Nmeal = man.prepareNonVegMeal();
        //    Nmeal.getItems().ForEach(c => { Console.WriteLine(c.name() + " : " + c.price()); });
        //    Console.WriteLine("Total price " + Nmeal.calcPrice());
        //}
    }
}
