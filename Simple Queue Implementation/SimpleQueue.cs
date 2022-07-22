using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Queue_Implementation
{
    internal class SimpleQueue
    {
        int[] arr;
        int front, rear;
        int maxSize;
        public SimpleQueue(int maxSize)
        {
            arr = new int[maxSize];
            front = -1;
            rear = -1;
            this.maxSize = maxSize;
        }

        public bool Add(int val)
        {
            if (rear == maxSize - 1)
                return false;
            else if(front==-1 && rear==-1)
            {
                front++;
                rear++;
                arr[front] = val;
            }
            else
            {
                rear++;
                arr[rear] = val;
            }
            return true;
        }

        public bool Delete()
        {
            if (front == -1 || front == maxSize)
                return false;
            else if (front == maxSize && rear == maxSize)
            {
                front = -1; rear = -1;
            }
            else
                front++;
            return true;
        }
        public bool IsFull()
        {
            if (front == maxSize - 1 || rear == maxSize - 1)
                return true;
            else
                return false;
        }
        public bool IsEmpty()
        {
            if (front == -1 || rear == -1||front==maxSize)
                return true;
            else
                return false;
        }
        public (bool,int) Peek()
        {
            if (front == -1||front==maxSize)
                return (false,0); 
            else
                return (true, arr[front]);
        }
        public List<int> Display()
        {
            List<int> list = new List<int>();
            for (int i = front; i <= rear; i++)
            {
                list.Add(arr[i]);
            }
            return list;
        }
    }
}
