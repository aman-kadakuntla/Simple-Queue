using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Queue_Implementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleQueue simpleQueue = new SimpleQueue(3);
            label:
            Console.WriteLine("1. Add \n2. Delete \n3. Check if full\n4. Check if empty\n" +
                "5. Print front element\n6. Display\n7. Exit");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    Console.WriteLine("Enter an element");
                    if (simpleQueue.Add(Convert.ToInt32(Console.ReadLine())))
                        Console.WriteLine("Added successfully");
                    else
                        Console.WriteLine("Element cannot be added since queue might be full");
                    goto label;
                case 2:
                    if (simpleQueue.Delete())
                        Console.WriteLine("Deleted successfully");
                    else
                        Console.WriteLine("Queue may be empty");
                    goto label;
                case 3:
                    if (simpleQueue.IsFull())
                        Console.WriteLine("Queue is full");
                    else
                        Console.WriteLine("Queue is not full");
                    goto label;
                case 4:
                    if (simpleQueue.IsEmpty())
                        Console.WriteLine("Queue is empty");
                    else
                        Console.WriteLine("Queue is not empty");
                    goto label;
                case 5:
                    var v=simpleQueue.Peek();
                    if (v.Item1)
                        Console.WriteLine("First element in the queue is "+v.Item2);
                    goto label;
                case 6:
                    if(simpleQueue.Display().Count()>0)
                    {
                        Console.Write("Elements in the queue are:");
                        foreach(int i in simpleQueue.Display())
                        {
                            Console.Write(i + " ");
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Queue is empty");
                    }
                    goto label;
                case 7:
                    return;
                default:
                    Console.WriteLine("Invalid choice");
                    goto label;
            }
            
        }
    }
}
