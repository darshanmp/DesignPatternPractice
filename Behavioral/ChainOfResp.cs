using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    abstract class AbstractLogger
    {
        private int level;
        AbstractLogger nextLogger = null;
        public AbstractLogger(int lev)
        {
            level = lev;
        }
        public void setNextLogger(AbstractLogger log)
        {
            nextLogger = log;
        }

        public void logMessage(int lev, string msg)
        {
            if(lev == level )
            {
                printMsg(lev, msg);
            }
            else
            {
                nextLogger.logMessage(lev, msg);
            }
        }
        public abstract void printMsg(int level, string msg);
    }
    class ErrorLogger : AbstractLogger
    {
        public ErrorLogger(int levl) : base(levl)
        {

        }

        public override void printMsg(int level, string msg)
        {
            Console.WriteLine("Error logger" + msg);
        }
    }

    class DebugLogger : AbstractLogger
    {
        public DebugLogger(int levl) : base(levl)
        {

        }

        public override void printMsg(int level, string msg)
        {
            Console.WriteLine("debug logger" + msg);
        }
    }
    class OtherError : AbstractLogger
    {
        public OtherError(int levl) : base(levl)
        {

        }

        public override void printMsg(int level, string msg)
        {
            Console.WriteLine("Other logger" + msg);
        }
    }

    class ChainOfRespMain
    {
        //public static void Main()
        //{
        //    ErrorLogger err = new ErrorLogger(1);
        //    DebugLogger deb = new DebugLogger(2);
        //    OtherError oth = new OtherError(3);
        //    err.setNextLogger(deb);
        //    deb.setNextLogger(oth);
        //    err.logMessage(1, "test1");
        //    err.logMessage(2, "test2");
        //    err.logMessage(3, "test3");
        //}
    }
}
