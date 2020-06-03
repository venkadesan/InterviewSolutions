using System;
using InterviewSolutions.DataStructure;
using InterviewSolutions.StackProblems;

namespace InterviewSolutions.Stack
{
    class Program
    {
        static void Main(string[] args)
        {


            Stack<int> myStack = new Stack<int>();
            myStack.push(10);
            myStack.push(3);
            myStack.push(8);
            myStack.push(5);
            myStack.push(11);
            myStack.push(2);
            StackSort stackSort = new StackSort();
            stackSort.Sort(myStack);




            FixedMultiStack multiStack = new FixedMultiStack(3);
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

            SetOfStacks stacks = new SetOfStacks(2);
            // pushing to stack data structure
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"pushing to Stack {i}");
                stacks.push(i);
            }
            stacks.PopAt(1);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"popping out of stack {stacks.Pop()}");
            }
            

        }
    }
}
