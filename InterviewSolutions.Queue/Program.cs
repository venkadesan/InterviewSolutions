using System;

namespace InterviewSolutions.Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            DataStructure.Queue<int> queue = new DataStructure.Queue<int>();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Queueing: {i} ");
                queue.EnQueue(i);
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Dequeuing count : {queue.DeQueue().ToString()}"); 
            }
        }
    }
}
