using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Demo
{
    public  class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose the below options");
                Console.WriteLine("1-Linked list demo");
                Console.WriteLine("2-stack program");
                Console.WriteLine("3-Linked List Node");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        //linked list using in-build methods
                         Linked linked = new Linked();
                          linked.Demo();
                          Console.WriteLine("\n");
                        break;
                    case 2:
                        //stack 
                         Stack_Demo stack = new Stack_Demo();
                         stack.Element();
                        Console.WriteLine("\n");
                        break;
                    case 3:
                        //linked list using user defined
                        LinkedList_Node linkedList_Node = new LinkedList_Node();
                        linkedList_Node.Add(4);
                        linkedList_Node.Add(55);
                        linkedList_Node.Add(23);
                       // LinkedList_Node<int> linkedList_Node_int = new LinkedList_Node<int>();
                        //linkedList_Node_int.Adds(4);
                        //linkedList_Node_int.Adds(55);
                        //linkedList_Node_int.Adds(23);
                        //Console.WriteLine("\n");
                        //LinkedList_Node<string> linkedList_Node_string = new LinkedList_Node<string>();
                        //linkedList_Node_string.Adds("Sai");
                        //linkedList_Node_string.Adds("Satya");
                        //linkedList_Node_string.Adds("Adabala");
                        Console.WriteLine("\n");
                        break;
                    default: 
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }
    }
}
