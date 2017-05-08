using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Structural.Flyweight
{
    //support large no of fine grained objects efficiently
    //Ex : browser image caching
    //factory keeps a cache of the entries
    abstract class Shape
    {
        abstract public void draw();
    }
    class Circle : Shape
    {
        public int X;
        public int Y;
        public int radius;
        public string color;
        public Circle(string colo)
        {
            color = colo;
        }
        public override void draw()
        {
            Console.WriteLine("Circle drawn at " + X + "," + Y + radius);
        }
    }
    public enum Color {Green,Red };
    class ShapeFactory
    {
        public Dictionary<string, Shape> hashMp = null;
        public ShapeFactory()
        {
            hashMp = new Dictionary<string, Shape>();
        }
        public Shape getCircle(string colo)
        {
            if(hashMp.ContainsKey(colo))
            {
                Console.WriteLine("returning the existing object");
                return hashMp[colo];
            }
            else
            {
                hashMp[colo] = new Circle(colo);
                Console.WriteLine("creating a new color in hashmap");
                return hashMp[colo];                
            }
        }
    }

    class FlyweightDP
    {
        //public static void Main()
        //{
        //    ShapeFactory fact = new ShapeFactory();
        //    Shape c1 = fact.getCircle("Red");
        //    Shape c2 = fact.getCircle("Green");
        //    Shape c3 = fact.getCircle("Red");
        //}
    }
}
