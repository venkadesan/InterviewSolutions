using System;
using System.Collections.Generic;
using System.Text;
using InterviewSolutions.DataStructure;

namespace InterviewSolutions.TreeProblems
{
    public class LevelLinkedList
    {

        #region CreateLevelLinkedLists
        public static List<LinkedList<TreeNode>> CreateLevelLinkedList(TreeNode node)
        {
            List<LinkedList<TreeNode>> lists = new List<LinkedList<TreeNode>>();
            createLevelLinkedList(node, lists, 0);
            return lists;
        }

        public static List<LinkedList<TreeNode>> CreateLevelLinkedListIterative(TreeNode root)
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

        private static void createLevelLinkedList(TreeNode root, List<LinkedList<TreeNode>> lists, int level)
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
    }
}
