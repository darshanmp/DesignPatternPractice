using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Structural
{
    //Proxy image class hiding a real image class and image is cached in proxy image class
    abstract class Image
    {
        abstract public void display();
    }
    class RealImage : Image
    {
        string fName;
        int height;
        int width;
        public RealImage(string fnam)
        {
            fName = fnam;
        }
        public override void display()
        {
            Console.WriteLine("Displaying " + fName);
        }
    }
    class ProxyImage : Image
    {
        private RealImage image;
        private string fname;
        public ProxyImage(string fnam)
        {
            fname = fnam;
        }
        public override void display()
        {
            if (image == null)
            {
                Console.WriteLine("loading newly");
                image = new RealImage(fname);
            }
            image.display();
        }

        class ProxyDP
        {
            //public static void Main()
            //{
            //    ProxyImage pi = new ProxyImage("tes1.jpg");
            //    pi.display();
            //    pi.display();

            //}
        }
    }
}
