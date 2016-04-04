using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class LinkedListNode <T>
    {
        public T value { set; get; }
        public  LinkedListNode<T> next {set; get;}

        public LinkedListNode()
        {
            next = null;
        }
        
        public LinkedListNode(T data) : this()
        {
            value = data;
        }

        public LinkedListNode(T data, LinkedListNode<T> newnext) : this (data)
        {
                next = newnext;
        }
    }
    public class MyLinkedList <T>
    {

        
        
        private LinkedListNode<T> head=null;
        private bool isempty = true;

        public bool AddNewNode(T NewElement)
        {
            LinkedListNode<T> temp;
            if (IsEmpty)
            {
                head = new LinkedListNode<T>(NewElement);
            }
            else
            {
                temp = new LinkedListNode<T>(NewElement, head);
                head = temp;
            }
            isempty = false;
            Console.WriteLine("---LinkedList message: Element added to the list...");
            return true;
        }
        public void RemoveHeadNode()
        {
            if (isempty)
            {
                Console.WriteLine("---LinkedList message: No more elements contained in linked list...");
            }
            else
            {
                Console.WriteLine("---LinkedList message: Element removed from list...");
                if (head.next == null)
                {
                    head.value = default(T);
                    isempty = true;
                }
                else
                {
                    head = head.next;
                }
            }
        }

        public T GetHeadValue()
        {
            if (isempty)
            {
                return default(T);
            }
                return head.value;
        
        }
       
        public bool IsEmpty
        {
            get
            {
                return isempty;
            }
        }

    }
}
