using System;
using System.Collections.Generic;
using System.Text;
using InterviewSolutions.DataStructure;

namespace InterviewSolutions.LinkedListProblems
{
    class LinkedListLoopDetection
    {
        public LinkedListNode FindLoopInLinkedList(DataStructure.LinkedList list)
        {
            if (list != null && list.head != null)
            {
                return GetLoopNode(list.head);
            }
            return null;
        }

        private LinkedListNode GetLoopNode(DataStructure.LinkedListNode node)
        {
            if (node == null)
            {
                return null;
            }
            LinkedListNode fasterNode = node;
            LinkedListNode slowerNode = node;
            while (fasterNode != null && fasterNode.Next != null)
            {
                fasterNode = fasterNode.Next.Next;
                slowerNode = slowerNode.Next;
                if (slowerNode == fasterNode) // Collision
                {
                    break;
                }
            }
            // No meeting point for faster node and slower node
            if (fasterNode == null || fasterNode.Next == null)
            {
                return null;
            }
            // moving slower node to head. 
            slowerNode = node;
            // Each are k steps from the look start. 
            while (slowerNode != fasterNode)
            {
                slowerNode = slowerNode.Next;
                fasterNode = fasterNode.Next;
            }
            return fasterNode;
        }
    }
}
