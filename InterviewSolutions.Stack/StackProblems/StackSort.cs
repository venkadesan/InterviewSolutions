using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterviewSolutions.DataStructure;

namespace InterviewSolutions.StackProblems
{
    public class StackSort
    {

        public void Sort(Stack<int> myStack)
        {
            Stack<int> tempStack = new Stack<int>();
            while (!myStack.IsEmpty())
            {
                int tmp = myStack.pop();
                while (!tempStack.IsEmpty() && tempStack.peek() > tmp)
                {
                    myStack.push(tempStack.pop());
                }
                tempStack.push(tmp);
            }
            while (!tempStack.IsEmpty())
            {
                myStack.push(tempStack.pop());
            }
        }
    }
}
