using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Structural
{
    //Structural DP , Composes a list of its own objects and marketed as a single object
    class Employee
    {
        public int salary;
        public int deptid;
        public string title;
        public List<Employee> subordLst;
        public Employee(int sal, int dep, string tit)
        {
            salary = sal;
            title = tit;
            deptid = dep;
            subordLst = new List<Employee>();
        }
        public void addSubord(Employee emp)
        {
            subordLst.Add(emp);
        }
        public void removeSubOrd(Employee emp)
        {
            subordLst.Remove(emp);
        }
        public List<Employee> getSubOrdList()
        {
            return subordLst;
        }
    }
    class CompositeDP
    {
        //public static void Main()
        //{
        //    Employee e1 = new Employee(10000,1,"CEO");
        //    Employee e2 = new Employee(10000, 1, "CFO");
        //    Employee e3 = new Employee(10000, 1, "COO");
        //    Employee e4 = new Employee(10000, 1, "CMO");
        //    e1.addSubord(e2);
        //    e1.addSubord(e3);
        //    e1.addSubord(e4);
        //    Console.WriteLine(e1.title);
        //    foreach(var i in e1.getSubOrdList())
        //    {
        //        Console.WriteLine("Title" + i.title);
        //    }
        //}
    }
}
