using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Queues
{
    class LimitedQueue<T>
    {
        private Queue<T> queue;
        private Object lockObject;
        private Semaphore semaphore;

        public LimitedQueue(int capacity)
        {
            if (capacity > 0)
            {
                lockObject = new object();
                semaphore = new Semaphore(capacity, capacity);
                queue = new Queue<T>(capacity);
            }
            else
            {
                throw new Exception("Error! Invalid capacity queue!");
            }
        }

        public void Enque(T item)
        {
            semaphore.WaitOne();
            queue.Enqueue(item);
        }

        public T Deque()
        {
            T item = default(T);
            if (queue.Count > 0)
            {
                lock (lockObject)
                {
                    if (queue.Count > 0)
                    {
                        item = queue.Dequeue();
                        semaphore.Release();
                    }
                }
            }
            return item;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            T[] tempArr = queue.ToArray();
            if (queue.Count != 0)
            {
                sb.Append("[");
                for(int i = 0; i < tempArr.Length; i++) 
                {
                    sb.Append(tempArr[i] + " ");
                }
                sb.Append("] ");
                sb.AppendFormat("({0})", tempArr.Length);
            }
            else
            {
                sb.Append("No items in queue");
            }
            return sb.ToString();
        }
    }
}
