using System;
using InterviewSolutions.DataStructure;
using InterviewSolutions.LinkedListProblems;

namespace InterviewSolutions.LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Linked List


            DataStructure.LinkedList ll = new DataStructure.LinkedList();
            int[] numbers = new int[] { 7, 1, 6 };
            int[] numbers1 = new int[] { 5, 9, 2 };
            //int[] numbers = new int[] { 1, 4, 3, 2, 5, 2 };

            foreach (int num in numbers)
            {
                if (ll.head == null) ll.head = new LinkedListNode(num);
                else ll.head.AppendNodeToTail(num);
            }

            DataStructure.LinkedList ll2 = new DataStructure.LinkedList();
            foreach (int num in numbers1)
            {
                if (ll2.head == null) ll2.head = new LinkedListNode(num);
                else ll2.head.AppendNodeToTail(num);
            }
            //LinkedListSolution solution = new LinkedListSolution();
            ////solution.RemoveDuplicates(ll.head);
            ////solution.RemoveDuplicatesRunnerTechnique(ll.head);
            //int kthLast = 3;

            //var node = solution.ReturnKthtoLast(ll.head, kthLast);
            //int parition = 3;
            //node = solution.Parition1(ll.head, parition);

            LinkedListAddHelper helper = new LinkedListAddHelper();
            var node = helper.AddLists(ll.head, ll2.head);
        }
    }
}
