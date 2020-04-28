using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewSolutions.DataStructure
{

    #region LinkedList
    public class LinkedList
    {
        public LinkedListNode head;
    }

    #endregion

    #region LinkedListNode
    public class LinkedListNode
    {
        public int Data;
        public LinkedListNode Next;
        public LinkedListNode Previous;

        #region Consturctor
        public LinkedListNode()
        {

        }
        public LinkedListNode(int data)
        {
            this.Data = data;
        }
        #endregion



        #region AppendNodeToTail
        public void AppendNodeToTail(int data)
        {
            LinkedListNode end = new LinkedListNode(data);
            LinkedListNode n = this;
            while (n.Next != null)
            {
                n = n.Next;
            }
            n.Next = end;
        }

        #endregion


        #region DeleteNode
        public LinkedListNode DeleteNode(LinkedListNode head, int data)
        {
            if (head != null)
            {
                LinkedListNode n = head;
                if (n.Data == data)
                {
                    return n.Next;
                }
                while (n.Next != null)
                {
                    if (n.Next.Data == data)
                    {
                        n.Next = n.Next.Next;
                    }
                    n = n.Next;
                }
            }
            return head;
        }

        #endregion

    }
    #endregion
}
