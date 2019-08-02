using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewSolutions.DataStructure
{

    #region Tree
    public class Tree
    {
        public Node root;

        #region InOrderTraversal
        public void InOrderTraversal(Node root)
        {
            if (root != null)
            {
                InOrderTraversal(root.left);
                Console.WriteLine(root.data);
                InOrderTraversal(root.right);
            }
        }
        #endregion


        #region PreOrderTraversal
        public void PreOrderTraversal(Node root)
        {
            if (root != null)
            {
                Console.WriteLine(root.data);
                PreOrderTraversal(root.left);
                PreOrderTraversal(root.right);
            }
        }

        #endregion


        #region PostOrderTraversal
        public void PostOrderTraversal(Node root)
        {
            if (root != null)
            {
                PostOrderTraversal(root.left);
                PostOrderTraversal(root.right);
                Console.WriteLine(root.data);
            }
        }

        #endregion


        #region InserstNode
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
            else if (root.data == value)
            {
                root.data = value;
            }
            else if (value < root.data)
            {
                Insert(ref root.left, value);
            }
            else
            {
                Insert(ref root.right, value);
            }
            return root;
        }

        #endregion


        #region Delete
        /// <summary>
        /// Deletes the value from binary serach tree
        /// </summary>
        /// <param name="root">Root node</param>
        /// <param name="value">Value to be inserted</param>
        /// <returns>Root LinkedListNode</returns>
        public Node Delete(ref Node root, int value)
        {

            if (root == null)
                return root;
            Node _nodeTobeDeleted = root;
            Node parentNode = null;
            while (_nodeTobeDeleted.data != value)
            {
                // if the value is greater than the value, it is in left side of the tree
                if (value > _nodeTobeDeleted.data)
                {
                    _nodeTobeDeleted = _nodeTobeDeleted.right;
                    parentNode = _nodeTobeDeleted;
                }
                else if (value < _nodeTobeDeleted.data)
                {
                    _nodeTobeDeleted = _nodeTobeDeleted.left;
                    parentNode = _nodeTobeDeleted;
                }

            }
            // We  now need to "rethread"  the tree.
            if (_nodeTobeDeleted != null && _nodeTobeDeleted.right == null)
            {
                _nodeTobeDeleted = _nodeTobeDeleted.left;
            }
            return root;
        }
        #endregion


        #region FindMinValue
        public int FindMinValue(Node root)
        {
            Node currentNode = root;
            int minValue = 0;
            while (currentNode.left != null)
            {
                currentNode = currentNode.left;
                minValue = currentNode.data;
            }
            return minValue;

        }

        #endregion


        #region ReplaceNodeInParent
        public void ReplaceNodeInParent(ref Node root, int newValue = 0)
        {

        }
        #endregion

    }
    #endregion

    #region Node
    public class Node
    {
        public int data;
        public Node left;
        public Node right;
        public Node(int item)
        {
            data = item;
        }


    }
    #endregion

}
