using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 300;
            MyStack<int> ms = new MyStack<int>();
            ms.Push(4);
            ms.Push(5);
            ms.Push(56);
            ms.Push(28);
            Console.WriteLine(ms.Pop());
            Console.WriteLine(ms.Pop());
            Console.WriteLine(ms.Pop());
            Console.WriteLine(ms.Pop());
            Console.WriteLine(ms.Pop());
            Console.WriteLine(ms.Pop());
            Console.WriteLine();
        }
    }
}
