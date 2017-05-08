using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Creational
{
    //Mainly used for cloning and making sure the actual object 
    //is not called a lot, shallow cloing possible while returning the object
    class Shape : ICloneable
    {
        private int id;
        protected int type;
        public int GetId()
        {
            return id;
        }
        public void SetId(int t)
        {
            id = t;
        }
        public int getType()
        {
            return type;
        }
        public void setType(int g)
        {
            type = g;
        }
        public object Clone()
        {
           return base.MemberwiseClone();      
        }
        public virtual void Draw() {}
    }
    class Rect : Shape
    {
        public Rect()
        {
                      
        }
        public override void Draw()
        {
            Console.WriteLine("Drawing a rectnagle");
        }
    }
    class Circle : Shape
    {        
        public Circle()
        {
            
        }
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }
    }
    class ShapeCache
    {
        private static Dictionary<int, Shape> dict = new Dictionary<int, Shape>();
        public static Shape getShape(int id)
        { 
            return (Shape)dict[id].Clone();           
        }
        public static void LoadToCache()
        {
            Rect r = new Rect();
            r.SetId(1);
            r.setType(1);
            Circle c = new Circle();
            c.SetId(2);
            c.setType(2);
            dict[1] = r;
            dict[2] = c;
        }
    }
    class PrototypeDP
    {
        public static void Main()
        {                        
            ShapeCache.LoadToCache();
            Shape clonShape =  ShapeCache.getShape(1);
            Console.WriteLine(clonShape.getType());
            Console.WriteLine(ShapeCache.getShape(2).getType());
        }
    }
}
