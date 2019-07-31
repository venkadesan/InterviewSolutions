using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewSolutions.DataStructure
{

    public class Tree
    {
        public Node root { get; set; }
        public void InOrderTraversal(Node root)
        {
            if (root != null)
            {
                InOrderTraversal(root.left);
                Console.WriteLine(root.data);
                InOrderTraversal(root.right);
             }
        }

        public void PreOrderTraversal(Node root)
        {
            if (root != null)
            {
                Console.WriteLine(root.data);
                PreOrderTraversal(root.left);
                PreOrderTraversal(root.right);
            }
        }

        public void PostOrderTraversal(Node root)
        {
            if (root != null)
            {
                PostOrderTraversal(root.left);
                PostOrderTraversal(root.right);
                Console.WriteLine(root.data);
            }
        }




    }
    public class Node
    {
        public int  data;
        public Node left;
        public Node right;
        public Node(int item)
        {
            data = item;
        }


    }
}
