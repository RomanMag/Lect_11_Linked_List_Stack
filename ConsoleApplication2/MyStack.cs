using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class MyStack<T> where T : IComparable
    {
        private MyLinkedList<T> mystack = new MyLinkedList<T>();

        public T Peek()
        {
            return mystack.GetHeadValue();
        }

        public T Pop()
        {
            T temp = default(T);
            if (IsEmpty())
            {
                Console.WriteLine("--pop is not possible, stack is empty, return default value");
            }
            else
            {
                Console.WriteLine("--perform pop on stack");                
                temp = mystack.GetHeadValue();
                mystack.RemoveHeadNode();
            }
            
            return temp;
        }
        public void Push(T newelement)
        {
            Console.WriteLine("--perform push to stack");
            mystack.AddNewNode(newelement);
        }
        
        public bool IsEmpty()
        {
            return mystack.IsEmpty;
        }
    }
}
