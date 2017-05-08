using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Structural
{
    // Shape Decorator extending new functionalities without affecting the original class
    abstract class Shape
    {
        public abstract void Draw();
    }
    class RedShape : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Red shapre drawn");
        }
    }
    class GreenShape : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Green shape drawn");
        }
    }
   abstract class Decorator : Shape
    {
        public Shape decoratedShape;
        public Decorator(Shape decor)
        {
            decoratedShape = decor;
        }
        public override void Draw()
        {
            decoratedShape.Draw();
        }

    }
    class RedDecorator : Decorator
    {
        public RedDecorator(Shape dec) : base(dec)
        {

        }
        public override void Draw()
        {
            decoratedShape.Draw();
            Console.WriteLine("Setting red border color");
        }       
    }
    class GreenShapeDecorator : Decorator
    {
        public GreenShapeDecorator(Shape dec) : base(dec)
        {

        }
        public override void Draw()
        {
            decoratedShape.Draw();
            Console.WriteLine("Setting green border color");
        }
    }
    class DecoratorDP
    {
        //public static void Main()
        //{
        //    Shape red = new RedShape();
        //    red.Draw();
        //    Shape redde = new RedDecorator(new RedShape());
        //    redde.Draw();
        //    Shape green = new GreenShapeDecorator(new GreenShape());
        //    green.Draw();
        //}
    }
}
