using System;
using System.Collections.Generic;
using InterviewSolutions.DataStructure;


namespace InterviewSolutions.StackProblems
{
    #region SetofStacks
    public class SetOfStacks
    {
        #region private variables
        public int _capactity = 0;
        public List<DataStructure.Stack<int>> stacks = new List<DataStructure.Stack<int>>();
        #endregion

        #region Constructor
        public SetOfStacks(int capacity)
        {
            _capactity = capacity;
        }
        public SetOfStacks()
        {
            _capactity = 10;
        }
        #endregion

        #region GetLastStack
        public DataStructure.Stack<int> GetLastStack()
        {
            if (stacks.Count == 0)
            {
                return null;
            }
            return stacks[stacks.Count - 1];
        }
        #endregion

        #region push
        public void push(int v)
        {
            DataStructure.Stack<int> last = GetLastStack();
            if (last != null && !last.IsFull())
            {
                last.push(v);
            }
            else
            {
                var stack = new DataStructure.Stack<int>(_capactity);
                stack.push(v);
                stacks.Add(stack);
            }

        }
        #endregion

        #region Pop
        public int Pop()
        {
            var lastStack = GetLastStack();
            if (lastStack == null || lastStack.IsEmpty())
            {
                throw new ArgumentException("Stack is empty");
            }
            int value = lastStack.pop();
            if (lastStack.IsEmpty())
            {
                stacks.Remove(lastStack);
            }
            return value;
        }
        #endregion

        #region IsEmpty
        public bool IsEmpty()
        {
            var stack = GetLastStack();
            return (stack == null || stack.IsEmpty());
        }
        #endregion

        #region PopAt
        public int PopAt(int index)
        {
            return leftShift(index, true);
        }
        #endregion

        #region leftShift
        private int leftShift(int index, Boolean removeTop)
        {
            var stack = stacks[index];
            int removed_item = 0;
            if (removeTop)
            {
                removed_item = stack.pop();
            }
            else
            {
                removed_item = stack.RemoveBottom();
            }
            if (stack.IsEmpty())
            {
                stacks.RemoveAt(index);
            }
            else if (stacks.Count > index + 1)
            {
                int v = leftShift(index + 1, false);
                stack.push(v);
            }
            return removed_item;

        }
        #endregion
    }
    #endregion

}
