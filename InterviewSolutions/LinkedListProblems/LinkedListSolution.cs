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

    }
}
