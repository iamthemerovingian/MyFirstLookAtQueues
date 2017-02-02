using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstLookAtQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            QueueExperiement1(queue);

            QueueArray<int> queueArray = new QueueArray<int>();
            QueueExperiement2(queueArray);
        }

        private static void QueueExperiement2(QueueArray<int> queue)
        {
            queue.AddtoQueue(1);
            queue.AddtoQueue(2);
            queue.AddtoQueue(3);
            queue.AddtoQueue(4);
            queue.DeQueue();
            queue.DeQueue();
            queue.DeQueue();
            queue.AddtoQueue(5);
            queue.AddtoQueue(6);
            queue.DeQueue();
            queue.AddtoQueue(7);
            queue.AddtoQueue(8);
            queue.DeQueue();
            queue.DeQueue();
            queue.DeQueue();
            queue.AddtoQueue(9);
            queue.DeQueue();
            queue.DeQueue();
        }
        private static void QueueExperiement1(Queue<int> queue)
        {
            queue.AddtoQueue(1);
            queue.AddtoQueue(2);
            queue.AddtoQueue(3);
            queue.AddtoQueue(4);
            queue.DeQueue();
            queue.DeQueue();
            queue.DeQueue();
            queue.AddtoQueue(5);
            queue.AddtoQueue(6);
            queue.DeQueue();
            queue.AddtoQueue(7);
            queue.AddtoQueue(8);
            queue.DeQueue();
            queue.DeQueue();
            queue.DeQueue();
            queue.AddtoQueue(9);
            queue.DeQueue();
            queue.DeQueue();
        }
    }
}
