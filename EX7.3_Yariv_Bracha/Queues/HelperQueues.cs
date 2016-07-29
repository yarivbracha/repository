using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Queues
{
    class HelperQueues
    {
        public void RunQueues()
        {
            LimitedQueue<int> queue = new LimitedQueue<int>(10);

            for (int i = 0; i < 50; i++)
            {
                ThreadPool.QueueUserWorkItem((obj) =>
                {
                    Random random = new Random();
                    int newItem = random.Next(1, 50);
                    if (newItem >= 25)
                    {
                        queue.Enque(newItem);
                        Console.WriteLine("The operation is enque, queue: " + queue);
                    }
                    else
                    {
                        int dequeValue = queue.Deque();
                        if (dequeValue != 0)
                        {
                            Console.WriteLine("The operation is deque, queue: " + queue);
                        }
                        else
                        {
                            Console.WriteLine("The deque rerjected!");
                        }
                    }
                    Thread.Sleep(1000);
                });
            }
            Console.Read();
        }
    }
}
