using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolutions.StackProblems
{
    public class StackMin : Stack<int>
    {
        Stack<int> s2;
        public StackMin() : base()
        {
            s2 = new Stack<int>();
        }

        #region push
        /// <summary>
        ///  pushs an element in the stack
        /// </summary>
        /// <param name="value">integer value to be pushed</param>
        public void push(int value)
        {
            if (value <= Min())
            {
                s2.Push(value);
            }
            base.Push(value);
        }
        #endregion


        #region pop
        /// <summary>
        ///  pops the element from the stack
        /// </summary>
        /// <returns></returns>
        public int pop()
        {
            int value = base.Pop();
            if (value == Min())
            {
               var val= s2.Pop();
            }
            return value;
        }
        #endregion


        #region min value
        /// <summary>
        ///  Get min value from the stack
        /// </summary>
        /// <returns></returns>
        public int Min()
        {
            if (s2.Count == 0)
            {
                return int.MaxValue;
            }
            else
            {
                return s2.Peek();
            }

        }
        #endregion

    }
}
