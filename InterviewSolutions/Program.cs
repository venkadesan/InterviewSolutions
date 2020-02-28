#region NameSpace
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterviewSolutions.DataStructure;
using InterviewSolutions.Algorithms;
using InterviewSolutions.Algorithms.Sorting;
using InterviewSolutions.OOP;
#endregion


namespace InterviewSolutions
{
    class Program
    {
        static void Main(string[] args)
        {


            //List<Person> lstOfPersons = new List<Person>();

            //Person person = new Person();
            //person.FirstName = "test";
            //lstOfPersons.Add(person);

            //Student student = new Student();
            //student.Grade = "10";
            //lstOfPersons.Add(student);

            // Sorting Algorithms
            //int[] a = new int[] {5,1,7,2,6,4,8,3 };

            //QuickSort qs = new QuickSort();
            //MergeSort ms = new MergeSort();

            //ms.Sort(a, 0, a.Length - 1);
            //int[] result= qs.SortArray(a, 0, a.Length - 1);



            // Tree Problem
            //InterviewSolutions.DataStructure.Tree tree = new InterviewSolutions.DataStructure.Tree();
            //tree.root = new InterviewSolutions.DataStructure.Node(1);
            //tree.root.left = new InterviewSolutions.DataStructure.Node(2);
            //tree.root.right = new InterviewSolutions.DataStructure.Node(3);
            //tree.root.left.left = new InterviewSolutions.DataStructure.Node(4);
            //tree.root.left.right = new InterviewSolutions.DataStructure.Node(5);

            //Console.WriteLine("Preorder traversal " +
            //                   "of binary tree is ");
            //tree.PreOrderTraversal(tree.root);

            //Console.WriteLine("\nInorder traversal " +
            //                    "of binary tree is ");
            //tree.InOrderTraversal(tree.root);

            //Console.WriteLine("\nPostorder traversal " +
            //                      "of binary tree is ");
            //tree.PostOrderTraversal(tree.root);


            //int[] a = new int[] { 1, 2, 4, 3, 4, 5 };
            //int[] rotate = new int[] { 0, 2, 3 };
            //int[] results = getMaxElementIndices(a, rotate);


            // Linked List

            //LinkedList ll = new LinkedList();
            //int[] numbers = new int[] { 1, 2, 4, 3, 4, 5 };
            //foreach(int num in numbers)
            //{
            //    if (ll.head == null) ll.head = new LinkedListNode(num);
            //    else ll.head.AppendNodeToTail(num);
            //}

            //int maxPosition = 10;
            //int[] start = new int[] { 3, 8 };
            //int[] end = new int[] { 4, 9 };
            //int result = widestGap(maxPosition, start, end);
            //Tree();
            //Console.WriteLine("Is a Palindrome"); 
            //Palindrome pal = new Palindrome();
            //string palindromCharacter = Console.ReadLine();
            //List<string> lstOfPermutations = new List<string>();
            //lstOfPermutations.Add(palindromCharacter);
            //pal.isPermuationPalindrome(palindromCharacter); 
            //if (pal.isPermuationPalindrome(palindromCharacter))
            //{
            //    Console.WriteLine(String.Format("The input character is a Palindrome {0}", palindromCharacter));
            //    Console.Read();  
            //}

            //OneAway oAway = new OneAway();
            //if (oAway.oneEditAway("pale", "pae"))
            //    Console.Write("Both Strings are one edit away");
            //else
            //    Console.Write("Both Strings are Not one Edit Away");

            //if (oAway.oneEditAwayVersion1("pale", "ble"))
            //{
            //    Console.Write("Both Strings are one edit away");
            //}
            //else
            //    Console.Write("Both Strings are Not one Edit Away");

            //StackProblems.FixedMultiStack multiStack = new StackProblems.FixedMultiStack(3);
            //// Inserting into first stack
            //multiStack.push(0, 1);
            //multiStack.push(0, 2);
            //// Test  test cimmmit 

            //multiStack.push(0, 3);
            //// Inserting into second stack
            //multiStack.push(1, 4);
            //multiStack.push(1, 5);
            //multiStack.push(1, 6);
            //// Inserting into third stack
            //multiStack.push(2, 7);
            //multiStack.push(2, 8);
            //multiStack.push(2, 9);

            //Console.WriteLine(multiStack.Pop(0).ToString());
            //Console.WriteLine(multiStack.Pop(0).ToString());
            //Console.WriteLine(multiStack.Pop(0).ToString());

            //Console.WriteLine(multiStack.Pop(1).ToString());
            //Console.WriteLine(multiStack.Pop(1).ToString());
            //Console.WriteLine(multiStack.Pop(1).ToString());

            //Console.WriteLine(multiStack.Pop(2).ToString());
            //Console.WriteLine(multiStack.Pop(2).ToString());
            //Console.WriteLine(multiStack.Pop(2).ToString());

            List<GraphNode> nodes = new List<GraphNode>();
            var node0 = new GraphNode("0");
            var node1 = new GraphNode("1");
            var node2 = new GraphNode("2");
            var node3 = new GraphNode("3");
            var node4 = new GraphNode("4");
            var node5 = new GraphNode("5");
            nodes.Add(node0);
            nodes.Add(node1);
            nodes.Add(node2);
            nodes.Add(node3);
            nodes.Add(node4);
            nodes.Add(node5);
            Graph G = new Graph(nodes);

            G.Add_Vertex(node0, node1);
            G.Add_Vertex(node0, node4);
            G.Add_Vertex(node0, node5);
            
            G.Add_Vertex(node1, node3);
            G.Add_Vertex(node1, node4);


            G.Add_Vertex(node3, node2);
            G.Add_Vertex(node3, node4);

            G.Add_Vertex(node2, node1);
            G.DFS(node0);

        }


        private static void Tree()
        {
            int[] binaryTree = new int[] { 5, 6, 11, 4, 7 };
            Tree tree = new Tree();
            // inserting value;
            Console.WriteLine("Building binary search Tree");
            foreach (int value in binaryTree)
            {
                if (tree.root == null)
                {
                    Console.WriteLine("Initializing the root node with value: {0}", value.ToString());
                    tree.root = new Node(value);
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

        private static int[] getMaxElementIndices(int[] a, int[] rotate)
        {
            List<int> rotatedResults = new List<int>();
            try
            {
                for (int rotateLength = 0; rotateLength < rotate.Length; rotateLength++)
                {

                    Queue<int> q = new Queue<int>(a);
                    Stack<int> s;
                    int rotateValue = rotate[rotateLength];
                    while (rotateValue > 0)
                    {
                        s = new Stack<int>(q);
                        int x = s.Pop();
                        s = new Stack<int>(s);
                        s.Push(x);
                        q = new Queue<int>(s);
                        rotateValue--;

                    }
                    var result = q.ToArray();
                    int maxValue = result.Max();
                    int maxIndex = result.ToList().IndexOf(maxValue);
                    rotatedResults.Add(maxIndex);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return rotatedResults.ToArray();
        }


        private static int widestGap(int n, int[] start, int[] end)
        {
            int gap = 0;
            if (n > 0 && start.Length > 0 && end.Length > 0 && start.Length == end.Length)
            {
                List<int> road = new List<int>(n);
                int totalNoOfCars = start.Length;
                List<int> lstofGaps = new List<int>();
                Queue<int> startQ = new Queue<int>(start);
                Queue<int> endQ = new Queue<int>(end);

                int startPosition = startQ.Dequeue();
                int endPosition = endQ.Dequeue();
                for (int position = 1; position <= road.Capacity; position++)
                {
                    if (endPosition > position || position > endPosition)
                    {
                        //car startPosition
                        if (startPosition != position && endPosition != position)
                        {
                            gap++;
                        }
                    }
                    else
                    {
                        lstofGaps.Add(gap);
                        gap = 0;
                        if (startQ.Count > 0)
                        {
                            startPosition = startQ.Dequeue();
                            endPosition = endQ.Dequeue();
                        }
                    }
                }


                int maxValue = lstofGaps.ToArray().Max();
            }
            return gap;

        }
    }



}


