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
        private LinkedListNode<T> tale=null;
        private bool isempty = true;

        public bool AddNewNode(T NewElement)
        {

            LinkedListNode <T> temp = new LinkedListNode<T>(NewElement, head);
            head = temp;
            return true;
        }
        public bool RemoveHeadNode()
        {
            head = head.next;
            return false;
        }

        public T GetHeadValue()
        {
            return head.value;
        }
       
        public bool IsEmpty()
        {
            return head.next == null;
        }

    }
}
