using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Behavioral
{
    //Operation Add/Subtract/Multiply example 
    //algorithm can be changed at run time for the context
    //similar to state pattern

    interface IStratergy
    {
        void doAction(int x,int y);
    }
    class OperationAdd : IStratergy
    {
        public void doAction(int x, int y)
        {
            Console.WriteLine("Add :" + (x + y));
        }
    }
    class OperationSubtract : IStratergy
    {
        public void doAction(int x, int y)
        {
            Console.WriteLine("Subtract :" + (x - y));
        }
    }
    class OperationMultiply : IStratergy
    {
        public void doAction(int x, int y)
        {
            Console.WriteLine("Multiply :" + (x * y));
        }
    }
    class Context
    {
        private IStratergy stratergy;
        
        public Context(IStratergy strat)
        {
            stratergy = strat;
        }
        public IStratergy getStrat()
        {
            return stratergy;
        }
        public void setStrat(IStratergy strat)
        {
            stratergy = strat;
        }
        public void executeStrat(int x, int y)
        {
            stratergy.doAction(x,y);
        }
    }
    class StratergyDP
    {
        //public static void Main()
        //{
        //    Context context = new Context(new OperationAdd());
        //    context.executeStrat(3, 4);
        //    context.setStrat(new OperationSubtract());
        //    context.executeStrat(4,3);
        //    context.setStrat(new OperationMultiply());
        //    context.executeStrat(4, 3);
        //}
    }
}
