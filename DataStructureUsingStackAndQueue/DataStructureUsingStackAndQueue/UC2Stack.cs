using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureUsingStackAndQueue
{
    public class UC2Stack
    {
         Node top;


        public UC2Stack()
        {
            this.top = null;
        }
        public void push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine(value);
        }

   
        public void peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("stack is empty");
            }
            Console.WriteLine("\n top of stack = " + this.top.data);
        }

   
        public void pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("stack is empty \n deletion is not possible");
            }
            Console.WriteLine("\n Pop out elememnt is = " + this.top.data);
            this.top = this.top.next;
        }

     
        public void isEmpty()
        {
            while (this.top != null)
            {
                peek();
                pop();
            }
            Console.WriteLine("Stack is empty");
        }

   
        public void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.WriteLine("elements in stack = " + temp.data);
                temp = temp.next;
            }
        }
    }

}