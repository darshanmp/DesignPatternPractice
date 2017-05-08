using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    interface IExpression
    {
        bool interpret(String context);
    }
    class TerminalExpression : IExpression
    {
        String data = "";
        public TerminalExpression(String dat)
        {
            data = dat;
        }
        public bool interpret(String context)
        {
            if (context.Contains(data)) return true;
            return false;
        }
    }
    class AndExpr: IExpression
    {
        private TerminalExpression exp11;
        private TerminalExpression exp21;

        public AndExpr()
        {

        }

        public AndExpr(TerminalExpression exp11, TerminalExpression exp21)
        {
            this.exp11 = exp11;
            this.exp21 = exp21;
        }
        public bool interpret(string context)
        {
            return exp11.interpret(context) && exp11.interpret(context);
        }
    }
    class OrExpr : IExpression
    {
        private TerminalExpression exp1;
        private TerminalExpression exp2;

        public OrExpr(TerminalExpression exp1, TerminalExpression exp2)
        {
            this.exp1 = exp1;
            this.exp2 = exp2;
        }

        public bool interpret(string context)
        {
            return exp1.interpret(context) || exp2.interpret(context);
        }
    }
    class InterpreterDP
    {
        //Rule : Both are male
        public static IExpression GetMaleExpressions(String str1,String str2)
        {
            TerminalExpression exp1 = new TerminalExpression(str1);
            TerminalExpression exp2 = new TerminalExpression(str2);
            return new OrExpr(exp1,exp2);
        }

        //Jennifer is a female
        public static IExpression GetFemaleExpression(String str1,String str2)
        {
            TerminalExpression exp1 = new TerminalExpression(str1);
            TerminalExpression exp2 = new TerminalExpression(str2);
            return new AndExpr(exp1, exp2);
        }
        //public static void Main()
        //{
        //    IExpression rule1 = GetMaleExpressions("Tom", "Harry");
        //    IExpression rule2 = GetFemaleExpression("Jennifer", "Married");
        //    Console.WriteLine("Enter the sentence to analyze");
        //    Console.WriteLine(rule1.interpret("Tom"));
        //    Console.WriteLine(rule1.interpret("Darshan"));
        //    Console.WriteLine(rule2.interpret("Married Jennifer"));
        //}
    }
}
