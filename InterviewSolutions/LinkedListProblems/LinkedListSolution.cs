using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterviewSolutions.DataStructure;

namespace InterviewSolutions.LinkedListProblems
{
    public class LinkedListSolution
    {

        #region RemovingDuplicates
        public void RemoveDuplicates(LinkedListNode node)
        {
            HashSet<int> hashset = new HashSet<int>();
            if (node != null)
            {
                LinkedListNode previous = null;
                while (node != null)
                {
                    if (hashset.Contains(node.Data))
                    {
                        previous.Next = node.Next;
                    }
                    else
                    {
                        hashset.Add(node.Data);
                        previous = node;
                    }
                    node = node.Next;
                }
            }
        }
        public void RemoveDuplicatesRunnerTechnique(LinkedListNode head)
        {
            var current = head;
            while (current != null)
            {
                var runner = current;
                while (runner.Next != null)
                {
                    if (runner.Next.Data == current.Data)
                    {
                        runner.Next = runner.Next.Next;
                    }
                    else
                    {
                        runner = runner.Next;
                    }
                }
                current = current.Next;
            }

        }
        #endregion

        #region ReturnKthToLast
        /// <summary>
        ///  Return Kth to Last
        /// </summary>
        /// <param name="head">LinkedListNode head</param>
        /// <param name="k">K th last</param>
        /// <returns>last element</returns>
        public LinkedListNode ReturnKthtoLast(LinkedListNode head, int k)
        {
            LinkedListNode p1 = head;
            LinkedListNode p2 = head;
            for (int i = 0; i < k; i++)
            {
                if (p1 == null) return null;
                p1 = p1.Next;
            }
            while (p1 != null)
            {
                p1 = p1.Next;
                p2 = p2.Next;
            }

            return p2;
        }
        #endregion

        #region DeleteMiddleNode
        public bool DeleteNode(LinkedListNode node)
        {
            if (node == null || node.Next == null)
            {
                return false;
            }
            LinkedListNode next = node.Next;
            node.Data = next.Data;
            node.Next = next.Next;
            return true;
        }
        #endregion
    }
}

