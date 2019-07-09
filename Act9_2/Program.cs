using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Request> reqList = new List<Request>();
            reqList.Add(new Request("Dan", 2, new DateTime(2018, 4, 2)));
            reqList.Add(new Request("Alice", 5, new DateTime(2018, 6, 12)));
            reqList.Add(new Request("Bill", 2, new DateTime(2018, 1, 23)));
            reqList.Add(new Request("Nemanja", 2, new DateTime(2018, 8, 30)));

            foreach(Request req in reqList)
            {
                Console.WriteLine(req.ToString());
            }

            Console.WriteLine("Sorted by date.");
            reqList.Sort(new DateSorter());

            foreach(Request req in reqList)
            {
                Console.WriteLine(req.ToString());
            }

            Console.WriteLine("Sorted by priority.");
            reqList.Sort(new PrioritySorter());

            foreach(Request req in reqList)
            {
                Console.WriteLine(req.ToString());
            }

        }
    }
}
