using InterviewSolutions.DataStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace InterviewSolutions.TreeProblems
{
    public class MinimalTree
    {
        #region public methods
        public static TreeNode CreateMinimalBST(int[] arr)
        {
            return CreateMinimalBST(arr, 0, arr.Length - 1);
        }

        #endregion

        #region private method
        private static TreeNode CreateMinimalBST(int[] arr, int start, int end)
        {
            if (end < start) return null;
            int mid = (start + end) / 2;
            TreeNode n = new TreeNode(arr[mid]);
            n.left = CreateMinimalBST(arr, start, mid - 1);
            n.right = CreateMinimalBST(arr, mid + 1, end);
            return n;
        }
        #endregion

    }
}
