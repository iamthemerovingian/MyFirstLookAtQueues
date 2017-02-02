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

        }

        private static void FIFO_Experiement()
        {
            Queue<int> queue = new Queue<int>();

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
