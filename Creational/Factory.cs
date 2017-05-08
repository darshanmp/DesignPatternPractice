using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Creational
{
    abstract class Sport
    {
        abstract public void Start();
        abstract public void Stop();
    }
    class Cricket : Sport
    {
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
        public override void Start()
        {
            Console.WriteLine("Football game started");
        }

        public override void Stop()
        {
            Console.WriteLine("Football game stopped");
        }
    }
    class Basketball : Sport
    {
        public override void Start()
        {
            Console.WriteLine("Basketball game started");
        }

        public override void Stop()
        {
            Console.WriteLine("Basketball game stopped");
        }
    }
    class Factory
    {
        public Factory()
        {

        }
        public Sport GetSportInstance(string sportName)
        {
            switch(sportName)
            {
                case "Cricket":
                    return new Cricket();
                case "Football":
                    return new Football();
                case "Basketball":
                    return new Basketball();
            }
            return null;
        }
    }

    class FactoryDP
    {
        //public static void Main()
        //{
        //    Factory fact = new Factory();
        //    Sport cr =  fact.GetSportInstance("Cricket");
        //    cr.Start();
        //    cr.Stop();
        //    Sport fo = fact.GetSportInstance("Football");
        //    fo.Start();
        //    fo.Stop();
        //    Sport bak = fact.GetSportInstance("Basketball");
        //    bak.Start();
        //    bak.Stop();
        //}
    }
}
