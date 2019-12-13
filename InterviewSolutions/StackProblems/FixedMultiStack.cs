using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewSolutions.StackProblems
{
    public class FixedMultiStack
    {
        #region private variables
        private int numberOfStacks = 3;
        private int stackCapacity;
        private int[] values;
        private int[] sizes;
        #endregion

        #region constructor
        public FixedMultiStack(int stackSize)
        {
            this.stackCapacity = stackSize;
            values = new int[stackCapacity * numberOfStacks];
            sizes = new int[numberOfStacks];
        }
        #endregion

        #region Stack Operations

        #region Push
        public void push(int stackNum, int value)
        {
            // check if we have space for next element.
            if (isFull(stackNum))
            {
                throw new Exception("Stack is Full");
            }
            // Increment stack pointer and then update top value;
            sizes[stackNum]++;
            values[indexofTop(stackNum)] = value;
        }
        #endregion

        #region Pop
        /// <summary>
        /// Pop item from top of stack.
        /// </summary>
        /// <param name="stackNum"></param>
        /// <returns>number</returns>
        public int Pop(int stackNum)
        {
            int value = 0;
            if (!isEmpty(stackNum))
            {
                int topIndex = indexofTop(stackNum);
                value = values[topIndex];
                values[topIndex] = 0;
                sizes[stackNum]--;
            }
            return value;
        }

        #endregion

        #region isFull
        /// <summary>
        /// Check if the stack is full
        /// </summary>
        /// <param name="stackNum">stack number</param>
        /// <returns>return true or false based on stack size.</returns>
        public Boolean isFull(int stackNum)
        {
            return sizes[stackNum] == stackCapacity;
        }
        #endregion

        #region "Peek"
        public int peek(int stackNum)
        {
            if (isEmpty(stackNum))
            {
                throw new Exception("stack is Empty");
            }
            return values[indexofTop(stackNum)];
        }
        #endregion
        #endregion

        #region private Methods
        private int indexofTop(int stackNum)
        {
            int offset = stackNum * stackCapacity;
            int size = sizes[stackNum];
            return offset + size - 1;
        }

        private Boolean isEmpty(int stackNum)
        {
            return sizes[stackNum] == 0;
        }

        #endregion
    }
}
