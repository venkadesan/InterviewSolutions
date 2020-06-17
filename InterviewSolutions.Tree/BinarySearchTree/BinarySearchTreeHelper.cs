using System;
using System.Collections.Generic;
using System.Text;
using InterviewSolutions.DataStructure;

namespace InterviewSolutions.BinarySearchTree
{
    class BinarySearchTreeHelper
    {

        #region InserstNode
        /// <summary>
        /// Insert a value to binary search tree
        /// </summary>
        /// <param name="root"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static TreeNode Insert(TreeNode root, int value)
        {
            if (root == null)
            {
                root = new TreeNode(value);
            }
            else if (root.data == value)
            {
                root.data = value;
            }
            else if (value < root.data)
            {
                Insert(root.left, value);
            }
            else
            {
                Insert(root.right, value);
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
        public static TreeNode Delete(ref TreeNode root, int value)
        {

            if (root == null)
                return root;
            TreeNode _nodeTobeDeleted = root;
            TreeNode parentNode = null;
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
        public static int FindMinValue(TreeNode root)
        {
            TreeNode currentNode = root;
            int minValue = 0;
            while (currentNode.left != null)
            {
                currentNode = currentNode.left;
                minValue = currentNode.data;
            }
            return minValue;

        }

        #endregion

        #region IsBalanced
        /// <summary>
        /// Checks if the tree is balanced tree or not.
        /// </summary>
        /// <param name="root">tree root</param>
        /// <returns>true or false based on sub trees</returns>
        public static bool IsBalanced(TreeNode root)
        {
            return (checkHeight(root) != Int32.MinValue);
        }

        private static int checkHeight(TreeNode root)
        {
            if (root == null) return -1;
            int leftHeight = checkHeight(root.left);
            if (leftHeight == Int32.MinValue) return Int32.MinValue;
            int rightHeight = checkHeight(root.right);
            if (rightHeight == Int32.MinValue) return Int32.MinValue;
            int heightDiff = leftHeight - rightHeight;
            if (Math.Abs(heightDiff) > 1)
            {
                return Int32.MinValue;
            }
            else return Math.Max(leftHeight, rightHeight) + 1;
        }
        #endregion

        #region ValidateBST
        public static  bool ValidateBST(TreeNode node)
        {
            return validateBST(node, 0, 0);
        }

        private static bool validateBST(TreeNode node, Int32 minVal, Int32 maxVal)
        {
            if (node == null) return true;
            if ((minVal != 0 && node.data <= minVal) || (maxVal != 0 && node.data > maxVal))
            {
                return false;
            }
            if (!validateBST(node.left, minVal, node.data) || !validateBST(node.right, node.data, maxVal))
            {
                return false;
            }
            return true;
        }

        #endregion

        #region Successor
        /// <summary>
        ///  In Order Successor of Binary Search tree.
        /// </summary>
        /// <param name="n">Tree Node.</param>
        /// <returns>Sucessor</returns>
        public static TreeNode InBSTOrderSuccessor(TreeNode n)
        {
            if (n == null) return null;
            /* Found right children -> return leftmost node of right subtree. */
            if (n.right != null)
            {
                return leftMostChild(n);
            }
            else
            {
                TreeNode q = n;
                TreeNode x = q.parent; //assing with parent.
                // Go up until we're on left instead of right.
                while (x != null && x.left != q)
                {
                    q = x;
                    x = x.parent;
                }
                return x;
            }
        }

        static TreeNode leftMostChild(TreeNode n)
        {
            if (n == null) return null;
            while (n.left != null)
            {
                n = n.left;
            }
            return n;
        }
        #endregion
    }
}
