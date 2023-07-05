using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Demo
{
    public class Queue_LinkedList
    {
        Node head=null;
        public void Enqueue(int data)
        {
            Node node = new Node(data);
            if (head==null)
            {
                head = node;
            }
            else
            {
                Node temp= head;
                while (temp.next!=null) 
                {
                    temp= temp.next;    
                }
                temp.next = node;
            }
            Console.WriteLine(node.data);
        }
        public void Dequeue()
        {
            if (head==null)
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                head = head.next;
            }
        }
        public void Display()
        {
            Node temp= head;    
            if(temp==null) 
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            while(temp!=null) 
            {
                Console.WriteLine(temp.data);
                temp= temp.next;    
            }
        }
    }
}
