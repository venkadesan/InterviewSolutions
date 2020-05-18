using System;
using System.Collections.Generic;
using System.Collections;
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


        #region Partition
        public LinkedListNode Partition(LinkedListNode node, int x)
        {
            LinkedListNode head = node;
            LinkedListNode tail = node;
            while (node != null)
            {
                LinkedListNode next = node.Next;
                if (node.Data < x)
                {
                    /* Insert node at head. */
                    node.Next = head;
                    head = node;
                }
                else if (node.Data >= x)
                {
                    /* Insert node at tail. */
                    tail.Next = node;
                    tail = node;
                }
                node = next;
            }
            tail.Next = null;
            return head;
        }

        public LinkedListNode Parition1(LinkedListNode node, int x)
        {
            LinkedListNode before_head = new LinkedListNode(0);
            LinkedListNode before = before_head;
            LinkedListNode after_head = new LinkedListNode(0);
            LinkedListNode after = after_head;

            while (node != null)
            {
                LinkedListNode next = node.Next;
                // If the original list node is lesser than the given x,
                // assign it to the before list.
                if (node.Data < x)
                {
                    before.Next = node;
                    before = before.Next;

                }
                else
                {

                    after.Next = node;
                    after = after.Next;

                }
                // move ahead in the original list
                node = next;
            }
            after.Next = null;
            // Merging sorting
            before.Next = after_head.Next;
            return before_head.Next;
        }
        #endregion


        #region FindIntersection
        public LinkedListNode FindIntersection(LinkedListNode list1, LinkedListNode list2)
        {
            if (list1 == null || list2 == null) return null;
            // Get tail and sizes
            var result1 = GetTailAndSize(list1);
            var result2 = GetTailAndSize(list2);
            // No interesection, if tails are different. tail have to be same for intersection linked list.
            if (result1.tail != result2.tail)
            {
                return null;
            }
            // Set pointer to the start of each linked list
            LinkedListNode shorter = result1.size < result2.size ? list1 : list2;
            LinkedListNode longer = result1.size < result2.size ? list2 : list1;

            longer = getKthNode(longer, Math.Abs(result1.size - result2.size));
            while (shorter != longer)
            {
                shorter = shorter.Next;
                longer = longer.Next;
            }
            return shorter;
        }


        #region getTailAndSize
        private Result GetTailAndSize(LinkedListNode list)
        {
            if (list == null) return null;
            int size = 1;
            LinkedListNode current = list;
            while (current.Next != null)
            {
                current = current.Next;
                size++;
            }
            return new Result(current, size);
        }
        #endregion


        #region getKthNode
        private LinkedListNode getKthNode(LinkedListNode head, int k){
            LinkedListNode current = head;
            while (k > 0 && current != null)
            {
                current = current.Next;
                k--;
            }
            return current;
        }
        #endregion

        #endregion

        public class Result
        {
            public LinkedListNode tail { get; set; }
            public int size = 0;
            public Result(LinkedListNode tail, int size)
            {
                this.tail = tail;
                this.size = size;
            }
        }
    }
}

