using System;
using System.Collections.Generic;
using System.Text;
using InterviewSolutions.DataStructure;

namespace InterviewSolutions.TreeProblems
{
    class TreeTraversals
    {
        #region Traversals

        #region InOrderTraversal
        public static void InOrderTraversal(TreeNode root)
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
        public static void PreOrderTraversal(TreeNode root)
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
        public static void PostOrderTraversal(TreeNode root)
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
    }
}
