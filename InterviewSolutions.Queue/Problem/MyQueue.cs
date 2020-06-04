using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolutions.Queue.Problem
{
    public class MyQueue<T>
    {
        #region private variable
        private Stack<T> newStack;
        private Stack<T> oldStack;
        #endregion

        #region constructor
        public MyQueue()
        {
            newStack = new Stack<T>();
            oldStack = new Stack<T>();
        }
        #endregion

        #region EnQueue
        /// <summary>
        ///  Queues item T to queue
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool EnQueue(T item)
        {
            newStack.Push(item);
            return true;
        }
        #endregion

        #region DeQueue
        /// <summary>
        /// Dequeue the element from queue.
        /// </summary>
        /// <returns></returns>
        public T DeQueue()
        {
            shiftStacks();
            return oldStack.Pop();
        }
        #endregion

        #region Peek
        /// <summary>
        /// Peeking at queue
        /// </summary>
        /// <returns></returns>
        public T Peek()
        {
            shiftStacks();
            return oldStack.Peek();
        }
        #endregion

        #region shiftStacks
        /// <summary>
        ///  Reversing from new stack to old stack so that we can pop/ peek the elements.
        /// </summary>
        private void shiftStacks()
        {
            if (oldStack.Count == 0)
            {
                while (newStack.Count != 0)
                {
                    oldStack.Push(newStack.Pop());
                }
            }
        }
        #endregion

    }
}
