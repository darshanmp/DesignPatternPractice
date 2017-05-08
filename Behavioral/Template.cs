using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    //cricket and football operations
    //Template pattern tells the subclasses / concrete classes to change some methods as per their liking however keeping the core algorithm order same
    abstract class Sport
    {
        public abstract void Initialize();
        public abstract void Start();
        public abstract void Stop();
        public void Play()
        {
            Initialize();
            Start();
            Stop();
        }
    }
    class Cricket : Sport
    {
        public override void Initialize()
        {
            Console.WriteLine("Cricket players reached ground");
        }

        public override void Start()
        {
            Console.WriteLine("Cricket game started");
        }

        public override void Stop()
        {
            Console.WriteLine("Cricket game stopped");
        }
    }
    class Football : Sport
    {
        public override void Initialize()
        {
            Console.WriteLine("Football players reached ground");
        }

        public override void Start()
        {
            Console.WriteLine("Football game stopped");
        }

        public override void Stop()
        {
            Console.WriteLine("Football game stopped");
        }
    }
    class TemplateDP
    {
        //public static void Main()
        //{
        //    Cricket cric = new Cricket();
        //    cric.Play();
        //    Football fball = new Football();
        //    fball.Play();
        //}
    }
}
