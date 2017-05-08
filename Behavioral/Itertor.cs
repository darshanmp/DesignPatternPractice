using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public interface Iterator
    {
         bool hasNext();
         String getNext();
    }
    public class NameRepository
    {
        public static String[] coll = { "Abc","Fox","Reuters","CBS" };
        public Iterator GetIterator()
        {
            return new NameIterator(); 
        }

        public class NameIterator : Iterator
        {
            int index;
            public string getNext()
            {
                if (this.hasNext()) return coll[index++];
                return null;
            }

            public bool hasNext()
            {                
                if (index <  coll.Length)
                    return true;
                return false;
            }
        }
    }

    class IteratorDP
    {
        //static void Main()
        //{
        //    NameRepository rep = new NameRepository();
        //    for(Iterator it = rep.GetIterator(); it.hasNext();)
        //    {
        //        String name = it.getNext();
        //        Console.WriteLine(name);
        //    }
        //}
    }
}
