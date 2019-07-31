using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewSolutions.Tree
{
    public class Node
    {
        private int _value;
        public int value
        {
            get { return _value; }
            set { _value = value; }
        }

        public Node(int value)
        {
            _value = value;
        }

        public Node()
        { }

        public Node LeftNode;
        public Node RightNode;


        /// <summary>
        /// Insert a value to binary search tree
        /// </summary>
        /// <param name="root"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public Node Insert(ref Node root, int value)
        {
            if (root == null)
            {
                root = new Node(value);
            }
            else if (root.value == value)
            {
                root.value = value;
            }
            else if (value < root.value)
            {
                Insert(ref root.LeftNode, value);
            }
            else
            {
                Insert(ref root.RightNode, value);
            }
            return root;
        }

        /// <summary>
        /// Deletes the value from binary serach tree
        /// </summary>
        /// <param name="root">Root node</param>
        /// <param name="value">Value to be inserted</param>
        /// <returns>Root Node</returns>
        public Node Delete(ref Node root, int value)
        {

            if (root == null)
                return root;
            Node _nodeTobeDeleted = root;
            Node parentNode = null;
            while (_nodeTobeDeleted.value!=value)
            {
                // if the value is greater than the value, it is in left side of the tree
                if (value > _nodeTobeDeleted.value)
                {
                    _nodeTobeDeleted = _nodeTobeDeleted.RightNode;
                    parentNode = _nodeTobeDeleted;
                }
                else if (value < _nodeTobeDeleted.value)
                {
                    _nodeTobeDeleted = _nodeTobeDeleted.LeftNode;
                    parentNode = _nodeTobeDeleted;
                }

            }
            // We  now need to "rethread"  the tree.
            if (_nodeTobeDeleted != null && _nodeTobeDeleted.RightNode == null)
            {
                _nodeTobeDeleted = _nodeTobeDeleted.LeftNode;
                }
            return root;
        }

        public int FindMinValue(Node root)
        {
            Node currentNode = root;
            int minValue = 0;
            while (currentNode.LeftNode != null)
            {
                currentNode = currentNode.LeftNode;
                minValue = currentNode.value;
            }
            return minValue;

        }

        public void ReplaceNodeInParent(ref Node root, int newValue =0)
        {

        }

    }

}
