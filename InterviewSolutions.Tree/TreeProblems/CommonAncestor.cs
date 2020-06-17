using System;
using System.Collections.Generic;
using System.Text;
using InterviewSolutions.DataStructure;

namespace InterviewSolutions.TreeProblems
{

    #region CommonAncestor
    public class CommonAncestor
    {
        public TreeNode FindFirstcommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            var result = commonAcHelper(root, p, q);
            if (result != null && result.isAncestor)
            {
                return result.node;
            }
            return null;
        }

        private Result commonAcHelper(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null)
            {
                return new Result(null, false);
            }
            Result rx = commonAcHelper(root.left, p, q);
            if (rx.isAncestor) // Found common Ancestor
            {
                return rx;
            }

            Result ry = commonAcHelper(root.right, p, q);
            if (ry.isAncestor) // Found common Ancestor
            {
                return ry;
            }
            if (rx.node != null && ry.node != null)
            {
                return new Result(root, true); // this is the common Acenstor.
            }
            else if (root == p || root == q)
            {
                bool isAncestor = rx.node != null || ry.node != null;
                return new Result(root, isAncestor);
            }
            else
            {
                return new Result(rx.node != null ? rx.node : ry.node, false);
            }

        }
    }
    #endregion

    #region Result Class
    public class Result
    {
        public TreeNode node { get; set; }
        public bool isAncestor { get; set; }

        public Result(TreeNode n, bool isAnc)
        {
            node = n;
            isAncestor = isAnc;
        }
    }
    #endregion

}
