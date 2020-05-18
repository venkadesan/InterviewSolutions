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
            DataStructure.LinkedList ll1 = new DataStructure.LinkedList();
            int[] numbers1 = new int[] { 3, 1, 5, 9 };
            Helper.GenerateList(ll1, numbers1);

            int[] numbers2 = new int[] { 7, 2, 1 };
            DataStructure.LinkedList ll2 = new DataStructure.LinkedList();
            Helper.GenerateList(ll2, numbers2);

            ll1.head.AppendNodeToTail(ll2.head);

            DataStructure.LinkedList ll3 = new DataStructure.LinkedList();
            int[] numbers3 = new int[] { 4, 6 };
            Helper.GenerateList(ll3, numbers3);

            ll3.head.AppendNodeToTail(ll2.head);

            LinkedListSolution solution = new LinkedListSolution();
            var node = solution.FindIntersection(ll1.head, ll3.head);
            ////solution.RemoveDuplicates(ll.head);
            ////solution.RemoveDuplicatesRunnerTechnique(ll.head);
            //int kthLast = 3;

            //var node = solution.ReturnKthtoLast(ll.head, kthLast);
            //int parition = 3;
            //node = solution.Parition1(ll.head, parition);

            //LinkedListAddHelper helper = new LinkedListAddHelper();
            //var node = helper.AddLists(ll.head, ll2.head);


        }
    }
}
