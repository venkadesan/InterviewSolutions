using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterviewSolutions.DataStructure;

namespace InterviewSolutions.LinkedListProblems
{
    public class LinkedListAddHelper
    {

        public LinkedListNode AddLists(LinkedListNode node1, LinkedListNode node2, int carry)
        {

            if (node1 == null && node2 == null && carry == 0)
            {
                return null;
            }
            LinkedListNode result = new LinkedListNode();
            int value = carry;
            if (node1 != null)
            {
                value += node1.Data;
            }

            if (node2 != null)
            {
                value += node2.Data;
            }
            result.Data = value % 10;

            if (node2 != null || node1 != null)
            {
                var nodeNext = node1 == null ? null : node1.Next;
                var nodeNext2 = node2 == null ? null : node2.Next;
                LinkedListNode more = AddLists(nodeNext, nodeNext2, value >= 10 ? 1 : 0);
                result.Next = more;
            }
            return result;
        }
    }
}
