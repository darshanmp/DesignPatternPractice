using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Creational
{
    //class has a static instance of itself ,private constructor, lazy intiliazation possible
    class StaticClass
    {
        private static StaticClass sclass = new StaticClass();
        private StaticClass()
        {
        }
        public static StaticClass getInst()
        {
            return sclass;
        }
        public void displ()
        {
            Console.WriteLine("Display the static class");
        }
    }
    class SingletonDp
    {
       //public static void Main()
       // {
       //     StaticClass s =  StaticClass.getInst();
       //     s.displ();            
       // }
    }
}
