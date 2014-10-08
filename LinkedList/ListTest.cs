using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class ListTest
    {
        static void Main(string[] args)
        {
            List list = new List();

            list.Add("A");
            list.Add("B");
            list.Add("C");
            list.Add("D");
            list.Add("E");
            list.Add("F");
            list.Add("G");
            list.Add("H");

            list.printNodes();
            Console.WriteLine();
            
            Console.WriteLine();
            Console.WriteLine("Deleting node 8");
            list.Delete(8);

            Console.WriteLine();
            list.printNodes();

            Console.WriteLine();
            Console.WriteLine("Postition 5: " + list.RetreiveNode(5).NodeContent);

            Console.WriteLine();
            Console.WriteLine("Deleting node 5");
            list.Delete(5);

            Console.WriteLine();
            Console.WriteLine("Position 5: " + list.RetreiveNode(5).NodeContent);

            Console.WriteLine();
            list.printNodes();

            Console.ReadLine();
        }
    }
}
