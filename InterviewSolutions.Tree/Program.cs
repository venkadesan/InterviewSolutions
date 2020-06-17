using System;
using System.Collections;
using System.Collections.Generic;
using InterviewSolutions.DataStructure;
using InterviewSolutions.TreeProblems;

namespace InterviewSolutions.Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tree Construction.
            var tree = new DataStructure.Tree();
            ConstructTree(tree);
            Console.WriteLine(SubTreeProblem.ContainsTree(tree.root, tree.root.left));
            var isBalanced = tree.IsBalanced(tree.root);
            Console.WriteLine($"Tree Balanced: {isBalanced.ToString()}");
            tree.ValidateBST(tree.root);

            // Constructing binary tree
            var binaryTree = new DataStructure.Tree();
            ConstructBinaryTree(binaryTree);
            CommonAncestor ancestor = new CommonAncestor();
            var firstCommonAncestor = ancestor.FindFirstcommonAncestor(binaryTree.root, binaryTree.root.left.left, binaryTree.root.right);
            Console.WriteLine($"CommonAncestor {firstCommonAncestor.data}");


            var lists = tree.CreateLevelLinkedListIterative(tree.root);


            List<int> arry = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            TreeNode node = MinimalTree.CreateMinimalBST(arry.ToArray());
            //Tree tree = new Tree();
            //tree.IsBalanced(node);
            tree.ValidateBST(node);

            TreeNode sucessor = tree.InBSTOrderSuccessor(node);


            Console.WriteLine(node.data);
            Console.WriteLine("Preorder traversal " +
                               "of binary tree is ");
            tree.PreOrderTraversal(tree.root);

            Console.WriteLine("\nInorder traversal " +
                                "of binary tree is ");
            tree.InOrderTraversal(tree.root);

            Console.WriteLine("\nPostorder traversal " +
                                  "of binary tree is ");
            tree.PostOrderTraversal(tree.root);


        }


        private static void Tree()
        {
            int[] binaryTree = new int[] { 5, 6, 11, 4, 7 };
            DataStructure.Tree tree = new DataStructure.Tree();
            // inserting value;
            Console.WriteLine("Building binary search Tree");
            foreach (int value in binaryTree)
            {
                if (tree.root == null)
                {
                    Console.WriteLine("Initializing the root node with value: {0}", value.ToString());
                    tree.root = new TreeNode(value);
                }
                else
                {
                    Console.WriteLine("Inserting LinkedListNode {0}", value.ToString());
                    tree.Insert(ref tree.root, value);
                }
            }
            Console.WriteLine("Enter value to be deleted");
            int valueToBeDeleted = Convert.ToInt16(Console.ReadLine());

        }

        private static void ConstructTree(DataStructure.Tree tree)
        {
            var root = new TreeNode(1);
            tree.root = root;
            var left = new TreeNode(2);
            tree.root.left = left;
            tree.root.left.parent = tree.root;
            tree.root.right = new TreeNode(3);
            tree.root.right.parent = tree.root;
            tree.root.left.left = new TreeNode(4);
            tree.root.left.left.parent = tree.root.left;
            tree.root.left.right = new TreeNode(5);
            tree.root.left.right.parent = tree.root.left;
        }


        private static void ConstructBinaryTree(DataStructure.Tree tree)
        {
            // Root
            var root = new TreeNode(20);
            tree.root = root;
            // left node
            var left = new TreeNode(10);
            tree.root.left = left;
            tree.root.left.parent = tree.root;
            //right node
            tree.root.right = new TreeNode(30);
            tree.root.right.parent = tree.root;

            // left node's left
            tree.root.left.left = new TreeNode(5);
            tree.root.left.left.parent = tree.root.left;

            // left node's right node
            tree.root.left.right = new TreeNode(15);
            tree.root.left.right.parent = tree.root.left;

        }

    }
}
