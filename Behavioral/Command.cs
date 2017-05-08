using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Stock
    {
        double price = 20;
        public void BuyStock()
        {
            Console.WriteLine("Bought stock at" + price);
        }
        public void SellStock()
        {
            Console.WriteLine("Sold stock at" + price);
        }
    }
    abstract class Order
    {
        public abstract void Execute();
    }
    class BuyStock : Order
    {
        private Stock stk;

        public BuyStock(Stock stk)
        {
            this.stk = stk;
        }

        public override void Execute()
        {
            stk.BuyStock();
        }
    }
    class SellStock : Order
    {
        private Stock stk;

        public SellStock(Stock stk)
        {
            this.stk = stk;
        }

        public override void Execute()
        {
            stk.SellStock();
        }
    }
    class Broker
    {
        private List<Order> ordls = null;
        public Broker()
        {
            ordls = new List<Order>();
        }
        public void TakeOrder(Order ord)
        {
            ordls.Add(ord);
        }
        public void PlaceOrders()
        {
            foreach(var ord in ordls)
            {
                ord.Execute();
            }
            ordls.Clear();
        }
    }
    class CommandMain
    {
        //public static void Main()
        //{
        //    Stock stk = new Stock();
        //    BuyStock bs = new BuyStock(stk);
        //    SellStock ss = new SellStock(stk);
        //    Broker br = new Broker();
        //    br.TakeOrder(bs);
        //    br.TakeOrder(ss);
        //    br.PlaceOrders();
        //}
    }

}
