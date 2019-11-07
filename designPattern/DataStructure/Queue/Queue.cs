using System;
using System.Collections.Generic;
using System.Text;

namespace designPattern.DataStructure.Queue
{
    class Queue
    {
        private static int front, rear, capacity;
        private static int[] queue;
        public Queue(int c)
        {
            front = rear = 0;
            capacity = c;
            queue = new int[capacity];
        }
        public void Dequeue()
        {
            if (front == rear)
            {
                Console.WriteLine("No elements");
            }
            else
            {
                for (int i = 0; i < rear - 1; i++)
                {
                    queue[i] = queue[i + 1];
                }

                if (rear<capacity)
                {
                    queue[rear] = 0;
                }
                rear--;
            }
        }
        public void Enqueue(int data)
        {
            if (capacity == rear)
            {

            }
            else
            {
                queue[rear] = data;
                rear++;
            }
        }
        public int Front() => queue[front];
        public bool IsEmpty()
        {
            return front == rear && rear == 0;
        }
        public bool IsFull()
        {
            return queue.Length == capacity;
        }
    }
}
