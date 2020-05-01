using System;
using InterviewSolutions.DataStructure;
using InterviewSolutions.StackProblems;

namespace InterviewSolutions.Stack
{
    class Program
    {
        static void Main(string[] args)
        {


            MyStack<int> myStack = new MyStack<int>();
            myStack.push(10);
            myStack.push(3);
            myStack.push(8);
            myStack.push(5);
            myStack.push(11);
            myStack.push(2);
            StackSort stackSort = new StackProblems.StackSort();
            stackSort.Sort(myStack);




            FixedMultiStack multiStack = new StackProblems.FixedMultiStack(3);
            // Inserting into first stack
            multiStack.push(0, 1);
            multiStack.push(0, 2);
            multiStack.push(0, 3);
            // Inserting into second stack
            multiStack.push(1, 4);
            multiStack.push(1, 5);
            multiStack.push(1, 6);
            // Inserting into third stack
            multiStack.push(2, 7);
            multiStack.push(2, 8);
            multiStack.push(2, 9);

            Console.WriteLine(multiStack.Pop(0).ToString());
            Console.WriteLine(multiStack.Pop(0).ToString());
            Console.WriteLine(multiStack.Pop(0).ToString());

            Console.WriteLine(multiStack.Pop(1).ToString());
            Console.WriteLine(multiStack.Pop(1).ToString());
            Console.WriteLine(multiStack.Pop(1).ToString());

            Console.WriteLine(multiStack.Pop(2).ToString());
            Console.WriteLine(multiStack.Pop(2).ToString());
            Console.WriteLine(multiStack.Pop(2).ToString());
        }
    }
}
