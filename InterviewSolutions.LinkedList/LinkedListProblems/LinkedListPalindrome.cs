using System;
using System.Text;
using InterviewSolutions.DataStructure;

namespace InterviewSolutions.LinkedListProblems
{
    public class LinkedListPalindrome
    {
        public bool IsPalindrome(LinkedListNode head)
        {
            int length = lengthOflist(head);
            Result p = isPalindromeRecurse(head, length);
            return p.result;

        }

        private Result isPalindromeRecurse(LinkedListNode head, int length)
        {
            if (head == null || length <= 0)
            {
                return new Result(head, true);
            }
            else if (length == 1)
            {
                return new Result(head.Next, true);
            }

            // Recurse on sublist 
            Result res = isPalindromeRecurse(head.Next, length - 2);
            if (!res.result || res.node == null)
            {
                return res;
            }
            res.result = (head.Data == res.node.Data);
            res.node = res.node.Next;
            return res;
        }

        private int lengthOflist(LinkedListNode head)
        {
            var node = head;
            int length = 0;
            while (node != null)
            {
                node = node.Next;
                length++;
            }
            return length;
        }

        class Result
        {

            public LinkedListNode node { get; set; }
            public bool result { get; set; }

            public Result(LinkedListNode n, bool res)
            {
                node = n;
            }
        }
    }
}
