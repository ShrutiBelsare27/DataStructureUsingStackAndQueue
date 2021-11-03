using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureUsingStackAndQueue
{
    public class UC1Stack
    {
        Node top;


        public UC1Stack()
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

            public void Display()
            {
                Node temp = this.top;
                while (temp != null)
                {
                    Console.WriteLine("Inserted into the stack Successfully = " + temp.data);
                    temp = temp.next;
                }
            }
        }
    
}

