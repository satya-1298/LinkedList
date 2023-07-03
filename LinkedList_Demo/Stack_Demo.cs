using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Demo
{
    public class Stack_Demo
    {
        public void Element()
        {
            //Adding elements
            Stack stack = new Stack();
            stack.Push("Satya");
            stack.Push("Bridge");
            stack.Push(3);
            stack.Push(4.33);
            stack.Push('c');
            foreach (var item in stack) //When we don't know which data type we have to perform we use var
                
            {
                Console.WriteLine("Elements in stack : "+item);
            }
            Console.WriteLine("Count is "+stack.Count);
            Console.WriteLine(stack.Contains(33));
            Console.WriteLine("Dispaly top element "+stack.Peek());
            foreach (var item in stack)
            {
                Console.WriteLine("Elements in stack : " + item);
            }
            Console.WriteLine("Removes the top element "+stack.Pop());
            foreach (var item in stack)
            {
                Console.WriteLine("Elements in stack : " + item);
            } 
        }
    }
}
