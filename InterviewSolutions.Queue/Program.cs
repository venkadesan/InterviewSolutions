using System;
using InterviewSolutions.Queue.Problem;
namespace InterviewSolutions.Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Custom queue implementation.
            CustomQueue();
            // Implemeting Queue using 2 stack data structures.
            MyQueue();



        }

        private static void MyQueue()
        {
            MyQueue<int> myQueue = new MyQueue<int>();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Queueing: {i} ");
                myQueue.EnQueue(i);
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Dequeuing count : {myQueue.DeQueue().ToString()}");
            }
        }


        private static void CustomQueue()
        {
            // Custom Queue implementation
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
