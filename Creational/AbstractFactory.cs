using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Creational.AbstractFactory
{
    //super factory - factory of factories
    //ball sport factory & other sport factory
    abstract class BallSport
    {
        abstract public void Start();
        abstract public void Stop();
    }
    class Cricket : BallSport
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
    class Football : BallSport
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
    class Basketball : BallSport
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


    abstract class OtherSport
    {
        abstract public void Start();
        abstract public void Stop();
    }

    class Swimming : OtherSport
    {
        public override void Start()
        {
            Console.WriteLine("Swimming game started");
        }

        public override void Stop()
        {
            Console.WriteLine("Swimming game stopped");
        }
    }

    class HorseRiding : OtherSport
    {
        public override void Start()
        {
            Console.WriteLine("HorseRiding game started");
        }

        public override void Stop()
        {
            Console.WriteLine("HorseRiding game stopped");
        }
    }

    class FactoryProducer
    {
        AbstractFactory ballFactory;
        AbstractFactory otherFactory;
        public AbstractFactory getFactory(string name)
        {
            if (name == "Ball")
                return new BallSportFactory();
            else
                return new OtherSportFactory(); 
        }
    }

    abstract class AbstractFactory
    {
        abstract public BallSport getBallSport(string name);
        abstract public OtherSport getOtherSport(string name);
    }

    class BallSportFactory : AbstractFactory
    {
        public override BallSport getBallSport(string sportName)
        {
            switch (sportName)
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

        public override OtherSport getOtherSport(string name)
        {
            return null;
        }
    }

    class OtherSportFactory : AbstractFactory
    {
        public override BallSport getBallSport(string sportName)
        {
            return null;
        }

        public override OtherSport getOtherSport(string name)
        {
            switch (name)
            {
                case "Swim":
                    return new Swimming();
                case "Horse":
                    return new HorseRiding();
            }
            return null;
        }
    }

    class AbstractFactoryDP
    {
        //public static void Main()
        //{
        //    FactoryProducer superfact = new FactoryProducer();
        //    AbstractFactory ballFact = superfact.getFactory("Ball");
        //    BallSport ball = ballFact.getBallSport("Cricket");
        //    ball.Start();
        //    ball.Stop();

        //    AbstractFactory otherFact = superfact.getFactory("Other");
        //    OtherSport other = otherFact.getOtherSport("Swim");
        //    other.Start();
        //    other.Stop();
        //}
    }
}
