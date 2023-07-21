using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryManagementDay10Ex2
{
    public class LargeDataCollection : IDisposable
    {
        List<string> list=new List<string>() { "sam", "rahul", "raj", "aditi" };
        static int totalItems;
        bool disposedValue;
        public LargeDataCollection() 
        {
            totalItems = 0;
            this.list = list;
        }
        public void Add(string item)
        {
            list.Add(item);
        }
        public void Remove(string item)
        {
            list.Remove(item);
        }
        public void Print()
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        public virtual void Dispose(bool disposing)
        {
            if (disposing) totalItems= 0;
            Console.WriteLine("the items are diposed and");
            disposedValue = true;

        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
