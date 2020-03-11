using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace InterviewSolutions.DataStructure
{

    #region Tree
    public class Tree
    {
        public TreeNode root;

        #region Traversals

        #region InOrderTraversal
        public void InOrderTraversal(TreeNode root)
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
        public void PreOrderTraversal(TreeNode root)
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
        public void PostOrderTraversal(TreeNode root)
        {
            if (root != null)
            {
                PostOrderTraversal(root.left);
                PostOrderTraversal(root.right);
                Console.WriteLine(root.data);
            }
        }

        #endregion

        #endregion

        #region InserstNode
        /// <summary>
        /// Insert a value to binary search tree
        /// </summary>
        /// <param name="root"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public TreeNode Insert(ref TreeNode root, int value)
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
        public TreeNode Delete(ref TreeNode root, int value)
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
        public int FindMinValue(TreeNode root)
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

        #region ReplaceNodeInParent
        public void ReplaceNodeInParent(ref TreeNode root, int newValue = 0)
        {

        }
        #endregion

        #region CreateLevelLinkedLists
        public List<LinkedList<TreeNode>> CreateLevelLinkedList(TreeNode node)
        {
            List<LinkedList<TreeNode>> lists = new List<LinkedList<TreeNode>>();
            createLevelLinkedList(node, lists, 0);
            return lists;
        }


        public List<LinkedList<TreeNode>> CreateLevelLinkedListIterative(TreeNode root)
        {
            List<LinkedList<TreeNode>> lists = new List<LinkedList<TreeNode>>();
            LinkedList<TreeNode> list = new LinkedList<TreeNode>();
            if (root != null)
            {
                list.AddLast(root);
            }
            while (list.Count > 0)
            {
                lists.Add(list);
                LinkedList<TreeNode> parentNode = list;
                list = new LinkedList<TreeNode>();
                foreach (var treeNode in parentNode)
                {
                    if (treeNode.left != null) list.AddLast(treeNode.left);
                    if (treeNode.right != null) list.AddLast(treeNode.right);
                }
            }
            return lists;
        }

        private void createLevelLinkedList(TreeNode root, List<LinkedList<TreeNode>> lists, int level)
        {
            if (root == null) return;
            LinkedList<TreeNode> list = null;
            if (lists.Count == level)
            {
                list = new LinkedList<TreeNode>();
                lists.Add(list);
            }
            else
            {
                list = lists[level];
            }
            list.AddLast(root);
            createLevelLinkedList(root.left, lists, level + 1);
            createLevelLinkedList(root.right, lists, level + 1);

        }

        #endregion

        #region IsBalanced
        /// <summary>
        /// Checks if the tree is balanced tree or not.
        /// </summary>
        /// <param name="root">tree root</param>
        /// <returns>true or false based on sub trees</returns>
        public bool IsBalanced(TreeNode root)
        {
            return (checkHeight(root) != Int32.MinValue);
        }

        private int checkHeight(TreeNode root)
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

        public bool ValidateBST(TreeNode node)
        {
            return validateBST(node, 0, 0);
        }

        private bool validateBST(TreeNode node, Int32 minVal, Int32 maxVal)
        {
            if (node == null) return true;
            if ((minVal!=0 && node.data <= minVal) || (maxVal != 0 && node.data > maxVal))
            {
                return false;
            }
            if (!validateBST(node.left, minVal, node.data) || !validateBST(node.right, node.data, maxVal))
            {
                return false;
            }
            return true;
        }

    

}
#endregion

#region Node
public class TreeNode
{
    public int data;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int item)
    {
        data = item;
    }


}
    #endregion

}
