using System;
using System.Collections.Generic;
using System.Text;
using InterviewSolutions.DataStructure;

namespace InterviewSolutions.Tree
{
    #region SubTreeProlbme
    public class SubTreeProblem
    {
        #region ContainsTree
        public static bool ContainsTree(DataStructure.TreeNode t1, DataStructure.TreeNode t2)
        {
            StringBuilder sb1 = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();
            getOrderString(t1, sb1);
            getOrderString(t2, sb2);
            return sb1.ToString().Contains(sb2.ToString());
        }
        #endregion

        #region getOrderString
        private static void getOrderString(TreeNode treeNode, StringBuilder sb)
        {
            if (treeNode == null)
            {
                sb.Append("x");
                return;
            }
            sb.Append(treeNode.data + " "); // Add root;
            getOrderString(treeNode.left, sb); // Add left;
            getOrderString(treeNode.right, sb); // Add right;

        }
        #endregion


    }
    #endregion

}
