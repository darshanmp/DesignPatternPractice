using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Structural.Facade
{
    //Facade patterns hides the complexity of underlying system
    //provides interface to the client which the client can access
    //ex: ShapeMaker - circle,rectangle,triangle
    abstract class Shape
    {
        public abstract void draw(); 
    }
    class Circle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing a circle");
        }
    }
    class Rectangle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing a rectangle");
        }
    }
    class Triangle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing a traingle");
        }
    }
    class ShapeMaker
    {
        Circle circle;
        Rectangle rectangle;
        Triangle triangle;
        public ShapeMaker()
        {
            circle = new Circle();
            triangle = new Triangle();
            rectangle = new Rectangle();
        }
        public void DrawCircle()
        {
            circle.draw();
        }
        public void DrawRectangle()
        {
            rectangle.draw();
        }
        public void DrawTriangle()
        {
            triangle.draw();
        }
    }
    class Facade
    {
        //public static void Main()
        //{
        //    ShapeMaker maker = new ShapeMaker();
        //    maker.DrawCircle();
        //    maker.DrawRectangle();
        //    maker.DrawTriangle();
        //}
    }
}
