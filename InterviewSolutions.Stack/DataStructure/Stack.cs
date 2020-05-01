using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewSolutions.DataStructure
{
    public class MyStack<T>
    {

        private StackNode<T> top;

        public T pop()
        {
            if (top == null) throw new Exception("Empty  stack");
            T item = top.data;
            top = top.next;
            return item;
        }

        public void push(T item)
        {
            StackNode<T> t = new StackNode<T>(item);
            t.next = top;
            top = t;
        }

        public T peek() {
            if (top == null) throw new Exception("Empty stack");
            return top.data;
        }

        public bool isEmpty()
        {
            if (top == null) return true;
            return false;

        }

    }

    class StackNode<T>
    {
        public T data { get; set; }
        public StackNode<T> next { get; set; }
        public StackNode(T _data)
        {
            data = _data;
        }
    }
}
