using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryManagementDay10Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            LargeDataCollection obj=new LargeDataCollection();
            Console.WriteLine("enetr an item to add");
            string item1=Console.ReadLine();
            obj.Add(item1);
            Console.WriteLine("enetr an item to remove");
            string item2 = Console.ReadLine();
            obj.Remove(item2);
            Console.WriteLine("list of items");
            obj.Print();
            obj.Dispose();
            Console.ReadKey();
        }
    }
}
