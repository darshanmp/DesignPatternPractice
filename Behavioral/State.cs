using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    //Start State and Stop State
    //just like state machine 
    class Context
    {
        private State data;
        public State getState()
        {
            return data;
        }
        public void setState(State inp)
        {
            data = inp;
        }

    }
    interface State
    {
        void doAction(Context context);
    }
    class StartState : State
    {
        public void doAction(Context context)
        {
            Console.WriteLine("Start state");
            context.setState(this);
        }
        public override string ToString()
        {
            return "Start";
        }
    }
    class StopState : State
    {
        public void doAction(Context context)
        {
            Console.WriteLine("Stop state");
            context.setState(this);
        }
        public override string ToString()
        {
            return "Stop";
        }
    }
    class StateDP
    {
        //public static void Main(string[] args)
        //{
        //    Context context = new Context();
        //    StartState ss = new StartState();
        //    ss.doAction(context);
        //    Console.WriteLine( context.getState().ToString());

        //    StopState ss1 = new StopState();
        //    ss1.doAction(context);
        //    Console.WriteLine(context.getState().ToString());

        //}
    }

}
