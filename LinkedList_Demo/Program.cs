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
            LinkedList_Node linkedList_Node = new LinkedList_Node();
            while (true)
            {
                Console.WriteLine("Choose the below options");
                Console.WriteLine("1-Linked list demo");
                Console.WriteLine("2-stack program");
                Console.WriteLine("3-Linked List Node");
                Console.WriteLine("4-List in Reverse order");
                Console.WriteLine("5-Remove first Element");
                Console.WriteLine("6-Remove last Element");
                Console.WriteLine("7-Size of Linked list");
                Console.WriteLine("8-Searching Elements");
                Console.WriteLine("9-Insert elements in stack");
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
                        //LinkedList_Node linkedList_Node = new LinkedList_Node();

                        linkedList_Node.Add(4);
                       // linkedList_Node.Display();
                        linkedList_Node.Add(55);
                       // linkedList_Node.Add(2);
                       // linkedList_Node.Add(8);
                       //// linkedList_Node.Display();
                       // linkedList_Node.Add(23);
                        linkedList_Node.Display();
                        
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
                    case 4:
                       // LinkedList_Node linkedList_Nodes = new LinkedList_Node();
                        linkedList_Node.Reverse_Order(33);
                        linkedList_Node.Reverse_Order(2);
                        linkedList_Node.Reverse_Order(76);
                        linkedList_Node.Display();
                        Console.WriteLine("\n");
                        break;
                    case 5:
                        linkedList_Node.Remove_First();
                        linkedList_Node.Display();
                        Console.WriteLine("\n");
                        break;
                    case 6:
                        linkedList_Node.Remove_Last();
                        linkedList_Node.Display();
                        Console.WriteLine("\n");
                        break;
                    case 7:
                        linkedList_Node.Size_Of_List();
                        linkedList_Node.Display();
                        Console.WriteLine("\n");
                        break;
                    case 8:
                        linkedList_Node.Search(55);
                        //Console.WriteLine("Element present in position - "+val);
                       // linkedList_Node.Display();
                       Console.ReadLine();
                        Console.WriteLine("\n");
                        break;
                    case 9:
                        StackLinkedList stackLinkedList = new StackLinkedList();
                        stackLinkedList.Push(66);
                        stackLinkedList.Push(2);
                        stackLinkedList.Push(8);
                        stackLinkedList.Display();
                        break;
                    default: 
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }
    }
}
