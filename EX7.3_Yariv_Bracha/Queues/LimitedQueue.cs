using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Queues
{
    class LimitedQueue<T>
    {
        private Queue<T> queue;
        private int capacity;
        private SemaphoreSlim semaphore;

        public LimitedQueue(int capacity)
        {
            this.capacity = capacity;
            semaphore = new SemaphoreSlim(capacity);
        }

        public void Enque(T item)
        {
            queue.Enqueue(item);
            capacity++;
        }

        public void Deque()
        {
             queue.Dequeue();
        }
    }
}
