using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace InterviewSolutions.Queue.DataStructure
{
    #region Queue
    public class Queue<T>
    {
        #region private variables
        private QueueNode<T> first;
        private QueueNode<T> last;
        #endregion

        #region constructor
        public Queue()
        {
        }
        #endregion

        #region EnQueue
        public bool EnQueue(T item)
        {
            if (item == null)
            {
                throw new Exception("item is null");
            }
            QueueNode<T> t = new QueueNode<T>(item);
            if (last != null)
            {
                last.next = t;

            }
            last = t;
            if (first == null)
            {
                first = last;
            }

            return true;
        }
        #endregion

        #region DeQueue
        public T DeQueue()
        {
            if (first == null) throw new Exception("There is no item to Queue");
            T data = first.data;
            first = first.next;
            if (first == null)
            {
                last = null;
            }
            return data;

        }
        #endregion

        #region Peek
        public T Peek()
        {
            if (first == null)
            {
                throw new Exception("Queue is empty");
            }
            return first.data;
        }
        #endregion

        #region IsEmtpy
        public bool IsEmpty()
        {
            return first == null;
        }

        #endregion

    }
    #endregion

    #region QueueNode
    public class QueueNode<T>
    {
        public T data;
        public QueueNode<T> next { get; set; }
        public QueueNode(T data)
        {
            this.data = data;
        }
    }
    #endregion

}
