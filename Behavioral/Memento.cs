using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento   
{
    class Memento
    {
        public string article { get; set; }
        public Memento(string art  )
        {
            article = art;
        }
    }
    class Originator
    {
        public string state { get; set; }
        public Memento Save(string article)
        {
            state = article;
            Console.WriteLine("Saved the state");
            return new Memento(article);
        }
        public void UndoState(Memento mem)
        {
            Console.WriteLine("Reverted back the change");
            state = mem.article;
        }
    }
    class Caretaker
    {
        List<Memento> memLst = new List<Memento>();
        public void Add(Memento mem)
        {

            memLst.Add(mem);
        }
        public Memento Get()
        {
            return memLst[0];
        }
    }
    //class MementoDP
    //{
    //    public static void Main()
    //    {
    //        Originator origin = new Originator();
    //        origin.Save("1");
    //        origin.Save("2");
    //        Caretaker care = new Caretaker();
    //        care.Add(origin.Save("3"));
    //        care.Add(origin.Save("4"));
    //        origin.UndoState(care.Get());
    //        Console.WriteLine(care.Get().article);
    //    }
    //}
}
