using System;
using System.Collections.Generic;
using System.Text;

namespace designPattern.DataStructure.Queue
{
    abstract class ADTQueue
    {
        public abstract void Enqueue(int data);
        public abstract void Dequeue();
        public abstract int Front();
        public abstract bool IsFull();
        public abstract bool IsEmpty();
    }
}
