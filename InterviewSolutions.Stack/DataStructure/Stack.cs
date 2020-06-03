using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewSolutions.DataStructure
{
    public class Stack<T>
    {

        #region private variables
        private Node<T> top;
        private Node<T> bottom;
        private int _capacity = 0;
        private int _size = 0;
        #endregion

        #region constructors
        public Stack()
        {
        }
        public Stack(int capacity)
        {
            _capacity = capacity;
        }
        #endregion

        #region pop
        public T pop()
        {
            if (top == null) throw new Exception("Empty  stack");
            T item = top.data;
            top = top.below;
            return item;
        }
        #endregion

        #region IsFull
        public bool IsFull()
        {
            return this._capacity == this._size;
        }
        #endregion

        private void Join(Node<T> above, Node<T> below)
        {
            if (below != null)
            {
                below.above = above;
            }
            if (above != null)
            {
                above.below = below;
            }
        }
        #region push
        /// <summary>
        /// Pushing an element to the top of the stack
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool push(T item)
        {
            if (_size >= _capacity) return false;
            _size++;
            Node<T> t = new Node<T>(item);
            if (_size == 1)
            {
                bottom = t;
            }
            Join(t, top);
            top = t;
            return true;
        }

        #endregion

        #region  Peek
        public T peek()
        {
            if (top == null) throw new Exception("Empty stack");
            return top.data;
        }
        #endregion

        #region RemoveBottom
        public T RemoveBottom()
        {
            Node<T> b = bottom;
            bottom = b.above;
            if (bottom != null)
            {
                bottom.below = null;
            }
            _size--;
            return b.data;
        }
        #endregion

        #region IsEmpty
        public bool IsEmpty()
        {
            if (top == null) return true;
            return false;

        }
        #endregion

    }

    class Node<T>
    {
        public T data { get; set; }
        public Node<T> below { get; set; }
        public Node<T> above { get; set; }
        public Node(T _data)
        {
            data = _data;
        }
    }
}
