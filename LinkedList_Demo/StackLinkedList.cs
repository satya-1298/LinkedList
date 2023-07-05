using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Demo
{
    public class StackLinkedList
    {
        public Node top;
        public StackLinkedList()
        {
            top = null;
        }
        public void Push(int data)
        {
            Node node = new Node(data);
            if (top==null)
            {
                node.next = null;
            }
            else 
            {
                node.next = top;
            }
            top = node; 
            Console.WriteLine("Elements in stack  " + data);
        }
        public void Display()
        {
            Node temp = top;
            while(temp != null) 
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
        //Will return top value but not delete it
        public void Peek()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            Console.WriteLine(top.data);
        }
    }
}
