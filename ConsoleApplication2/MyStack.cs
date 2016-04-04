using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class MyStack<T>
    {
        private MyLinkedList<T> mystack = new MyLinkedList<T>();

        public T Peek()
        {
            if (mystack.GetHeadValue() != null)
            { return mystack.GetHeadValue(); }
            return default(T);
        }

        public T Pop()
        {
            T temp = default(T);
            if (mystack.GetHeadValue() != null)
            {
                temp = mystack.GetHeadValue();
                mystack.RemoveHeadNode();
            }

            return temp;
        }
        public void Push(T newelement)
        {
            mystack.AddNewNode(newelement);
        }

    }
}
