using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDP    
{
    //Chat room
    public interface IMediator
    {
        void SendMessageToColl(string message, Colleague currCol);
    }

    class ConcreteMediator : IMediator
    {
        private List<Colleague> collLst = null;
        public ConcreteMediator()
        {
            collLst = new List<Colleague>();
        }
        public void AddColl(Colleague col)
        {
            collLst.Add(col);
        }
        public void RemoveColl(Colleague col)
        {
            collLst.Remove(col);
        }

        public void SendMessageToColl(string message, Colleague currCol)
        {
            foreach(var col in collLst)
            {
                if(col != currCol)
                col.ReceiveMsg(message);
            }
        }
    }

    public abstract class Colleague
    {
        public IMediator mediator;
        public Colleague(IMediator med)
        {
            mediator = med;
        }
        public void SendToMediator(string mesg)
        {
            mediator.SendMessageToColl(mesg, this);
        }
        internal abstract void ReceiveMsg(string message);
    }

    public class ConcreteColleague : Colleague
    {
        public ConcreteColleague(IMediator med) : base(med)
        {

        }

        internal override void ReceiveMsg(string message)
        {
            Console.WriteLine("Rec mes:" + message);
        }
    }
    class MediatorMain
    {
        //public static void Main()
        //{
        //    ConcreteMediator med = new ConcreteMediator();
        //    ConcreteColleague cc1 = new ConcreteColleague(med);
        //    ConcreteColleague cc2 = new ConcreteColleague(med);
        //    med.AddColl(cc1);
        //    med.AddColl(cc2);
        //    cc1.SendToMediator("TEst1");

        //}
    }
}
