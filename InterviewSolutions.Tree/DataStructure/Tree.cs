using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewSolutions.DataStructure
{

    #region Tree
    public class Tree
    {
        public TreeNode root;
    }
    #endregion

    #region Node
    public class TreeNode
    {
        public int data;
        public TreeNode left;
        public TreeNode right;
        public TreeNode parent;
        public TreeNode(int item)
        {
            data = item;
        }


    }
    #endregion

}
