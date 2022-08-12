using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class Queue
    {
        public static void InsertDataQueue()
        {
            Console.WriteLine("Insert data using queue");
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);


            foreach (int item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("After Dequue ");

          
        }
    }
}
