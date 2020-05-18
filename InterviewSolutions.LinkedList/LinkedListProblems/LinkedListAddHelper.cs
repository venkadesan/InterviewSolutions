using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterviewSolutions.DataStructure;

namespace InterviewSolutions.LinkedListProblems
{

    public class PartialSum
    {
        public LinkedListNode Sum { get; set; }
        public int Carry { get; set; }
    }


    #region LinkedListHelper Class
    public class LinkedListAddHelper
    {

        public LinkedListNode AddLists(LinkedListNode node1, LinkedListNode node2)
        {

            int len1 = Length(node1);
            int len2 = Length(node2);

            if (node1 == null && node2 == null)
            {
                return null;
            }
            if (len1 > len2)
            {
                node2 = PadList(node2, len1 - len2);
            }
            else
            {
                node1 = PadList(node1, len2 - len1);
            }
            PartialSum sum = AddListHelper(node1, node2);

            if (sum.Carry == 0)
            {
                return sum.Sum;
            }
            else
            {
                LinkedListNode result = InsertBefore(sum.Sum, sum.Carry);
                return result;
            }
        }

        private PartialSum AddListHelper(LinkedListNode node1, LinkedListNode node2)
        {
            if (node1 == null && node2 == null)
            {
                return new PartialSum();
            }

            PartialSum sum = AddListHelper(node1.Next, node2.Next);
            int val = sum.Carry + node1.Data + node2.Data;
            LinkedListNode full_result = InsertBefore(sum.Sum, val % 10);
            sum.Sum = full_result;
            sum.Carry = val / 10;

            return sum;
        }

        private LinkedListNode PadList(LinkedListNode node, int padding)
        {

            LinkedListNode head = node;
            if (head != null && padding > 0)
            {
                for (int i = 0; i < padding; i++)
                {
                    head = InsertBefore(head, 0);
                }

            }
            return head;
        }

        private LinkedListNode InsertBefore(LinkedListNode list, int data)
        {
            LinkedListNode node = new LinkedListNode(data);
            if (list != null)
            {
                node.Next = list;
            }
            return node;
        }

        private int Length(LinkedListNode head)
        {
            LinkedListNode node = head;
            int len = 0;
            while (node != null)
            {
                len++;
                node = node.Next;
            }
            return len;
        }
    }
    #endregion


    #region LinkedListHelperClass

    public static class Helper
    {
        public static void GenerateList(DataStructure.LinkedList ll, int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return;

            foreach (int num in numbers)
            {
                if (ll.head == null)
                {
                    ll.head = new LinkedListNode(num);
                }
                else
                {
                    ll.head.AppendNodeToTail(num);
                }
            }

        }
    }
    #endregion
}
