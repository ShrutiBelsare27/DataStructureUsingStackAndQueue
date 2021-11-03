using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureUsingStackAndQueue
{
    public class UC3Queue
    {
        Node head;
        public UC3Queue()
        {
            this.head = null;
        }

        public void EnQueue(int data)
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
                // this.head = temp;

            }
        }
        public void display()
        {
            if (head == null)
            {
                Console.WriteLine("Queue is empty");

            }
            else
            {
                Node temp = head;
                while (temp != null && temp.data != null)
                {
                    Console.WriteLine("Data:" + temp.data);
                    temp = temp.next;
                }
            }
        }
    }
}
