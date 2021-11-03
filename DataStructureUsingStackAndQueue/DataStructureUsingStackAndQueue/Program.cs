using System;

namespace DataStructureUsingStackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("UC1");
            UC1Stack linkedListStack = new UC1Stack();
            linkedListStack.push(70);
            linkedListStack.push(30);
            linkedListStack.push(56);
            linkedListStack.Display();

            Console.WriteLine("UC2");
            UC2Stack linkedListStack1 = new UC2Stack();
            linkedListStack1.push(70);
            linkedListStack1.push(30);
            linkedListStack1.push(56);
            linkedListStack1.Display();
            linkedListStack1.peek();
            linkedListStack1.Display();
            linkedListStack1.pop();
            linkedListStack1.Display();
            linkedListStack1.isEmpty();
            linkedListStack1.Display();

            Console.WriteLine("\n UC3 for EnQueue");
            UC3Queue queue = new UC3Queue();
            queue.EnQueue(56);
            queue.EnQueue(30);
            queue.EnQueue(70);
            queue.display();

            Console.WriteLine("\n UC4 for DeQueue");
            UC4Queue queue1 = new UC4Queue();
            queue1.EnQueue(56);
            queue1.EnQueue(30);
            queue1.EnQueue(70);
            queue1.display();

            queue1.DeQueue();
            queue1.display();
            Console.ReadKey();

        }
    }
}