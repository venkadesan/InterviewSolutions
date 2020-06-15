using System;
using InterviewSolutions.DataStructure;
using InterviewSolutions.StackProblems;

namespace InterviewSolutions.Stack
{
    class Program
    {
        static void Main(string[] args)
        {

            // Sorting the stack
            sortingStack();
            // min stack 
            minStack();
            // Multi stack 
            fixedSizeMultiStack();
            // set of stacks
            setofStack();

        }

        static void minStack()
        {

            // STack min problem
            StackMin min = new StackMin();

            // pushing the data to min stack
            Console.WriteLine($"Pushing {5} to Min Stack:");
            min.push(5);
            Console.WriteLine($"Current Min value :{min.Min()}");

            Console.WriteLine($"Pushing {6} to Min Stack:");
            min.push(6);
            Console.WriteLine($"Current Min value :{min.Min()}");

            Console.WriteLine($"Pushing {3} to Min Stack");
            min.push(3);
            Console.WriteLine($"Current Min value :{min.Min()}");

            Console.WriteLine($"Pushing {7} to Min Stack");
            Console.WriteLine(min.Min());
            Console.WriteLine($"Current Min value :{min.Min()}");
            min.push(7);

            // popping the data from the stack
            while (min.Count != 0)
            {
                Console.WriteLine($"popping from the current stack :{min.pop()}");
                Console.WriteLine($"Current Min value :{min.Min()}");
            }

        }

        static void sortingStack()
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

        }

        static void fixedSizeMultiStack()
        {
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

        }
        static void setofStack()
        {

            SetOfStacks stacks = new SetOfStacks(2);
            // pushing to stack data structure
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"pushing to Stack {i}");
                stacks.push(i);
            }
            stacks.PopAt(2);
            for (int i = 0; i < 10; i++)
            {
                if (!stacks.IsEmpty())
                {
                    Console.WriteLine($"popping out of stack {stacks.Pop()}");
                }
            }

        }
    }
}
