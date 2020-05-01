using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterviewSolutions.DataStructure;

namespace InterviewSolutions.StackProblems
{
    public class StackSort
    {

        public void Sort(MyStack<int> myStack)
        {
            MyStack<int> tempStack = new MyStack<int>();
            while (!myStack.isEmpty())
            {
                int tmp = myStack.pop();
                while (!tempStack.isEmpty() && tempStack.peek() > tmp)
                {
                    myStack.push(tempStack.pop());
                }
                tempStack.push(tmp);
            }
            while (!tempStack.isEmpty())
            {
                myStack.push(tempStack.pop());
            }
        }
    }
}
