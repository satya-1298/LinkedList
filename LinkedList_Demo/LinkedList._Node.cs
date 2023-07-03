using System;
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
