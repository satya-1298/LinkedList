using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Demo
{
    //Linked list is a linear data structure which stores the element in the non-contiguous location
    //The node had element are linked with each other using pointer
    //Linked list class allows insertion and deletion of element from a list very fastly
    //Node-Node will be your Exact value 
    //next-reference of the next node
    public class Linked
    {
        public void Demo()
        {
            LinkedList<int> demo = new LinkedList<int>();
            demo.AddLast(3);
            demo.AddLast(4);
            demo.AddLast(5);
            demo.AddLast(6);
            demo.AddFirst(2);

            foreach (int val in demo) 
            {
                Console.WriteLine("Elements in Linked list : " + val);
                //Console.WriteLine("No.of Elements in list are - "+demo.Count);
                //Console.WriteLine("Find the element " + demo.Contains(3));
                //Console.WriteLine("Elements in Linked list : " + val);

            }
            Console.WriteLine("Removed a element from list " + demo.Remove(2));
            foreach (int val in demo)
            {
                Console.WriteLine("Elements in list are - " + val);

            }
            Console.WriteLine("Removed a element from list " );
            demo.Remove(demo.First);
            foreach (int val in demo)
            {
                Console.WriteLine("Elements in list are - " + val);

            }
            Console.WriteLine("Count is " + demo.Count);
            Console.WriteLine("Removed a element from list ");
            demo.Remove(demo.Last);
            foreach (int val in demo)
            {
                Console.WriteLine("Elements in list are - " + val);

            }
            demo.Clear();
            foreach (int val in demo)
            {
                Console.WriteLine("Deleted elements from list - "+val);

            }
            Console.WriteLine("Count is " + demo.Count);
            if(demo.Contains(3)==true)
            {
                Console.WriteLine("The element was present");
            }
            else
            {
                Console.WriteLine("Element not found");
            }






        }
    }
}
