using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedList_Demo
{
    public class LinkedList_Node  //<T>
    {
        public Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted in to Linked list ", data);
        }
        public void Display()
        {
            Node temp = head;
            if(temp==null)
            {
                Console.WriteLine("List is Empty");
            }
            while(temp!=null) 
            {
                Console.WriteLine(temp.data);
                 temp = temp.next;
                
            }
        }
        public void Reverse_Order(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                head = node;
                head.next= temp;

            }
        }
        public void Remove_First()
        {
            if (head == null)
            {
                Console.WriteLine("List is Empty");
            }
            head= head.next;
            Console.WriteLine("First Element Deleted Successfully");
        }
        public void Remove_Last()
        {
            if (head == null)
            {
                Console.WriteLine("List is Empty");
            }
            if (head.next == null)
            {
                Console.WriteLine("The next element of head is null");
            }
            else
            {

                Node temp = head;
                while (temp.next.next != null)
                {
                    temp = temp.next;
                }
                temp.next = null;
                Console.WriteLine("Removed last element");
            }

        }
        //public Node<T> head;

        //public void Adds(T data)
        //{
        //    Node<T> node = new Node<T>(data);
        //    if (head == null)
        //    {
        //        head = node;
        //    }
        //    else
        //    {
        //        Node<T> temp = head;
        //        while (temp.next != null)
        //        {
        //            temp = temp.next;
        //        }
        //        temp.next = node;
        //    }
        //    Console.WriteLine("{0} : inserted in to Linked list ", data);

        //}
    }
}
