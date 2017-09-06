using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list =new LinkedList<int>();

            list.AddToTail(5);
            list.AddToTail(15);
            list.AddToTail(30);
            list.AddToHead(2);
            list.AddToTail(3);
            list.AddToHead(17);
            list.AddToHead(2);

            Console.WriteLine(list.Remove(2));

            Console.WriteLine("Количество элементов - {0}",list.Count);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }
    }
}
