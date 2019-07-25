using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterviewSolutions.Tree;
using InterviewSolutions.Algorithms;
using InterviewSolutions.Algorithms.Sorting;


namespace InterviewSolutions
{
    class Program
    {
        static void Main(string[] args)
        {

            QuickSort qs = new QuickSort();
            int[] a = new int[] {5,1,7,2,6,4,8,3 };

            int[] result= qs.SortArray(a, 0, a.Length - 1);
            //int[] a = new int[] { 1, 2, 4, 3, 4, 5 };
            //int[] rotate = new int[] { 0, 2, 3 };
            //int[] results = getMaxElementIndices(a, rotate);



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



        }


        private static void Tree()
        {
            int[] binaryTree = new int[] { 5, 6, 11, 4, 7 };
            Node root = null;
            // inserting value;
            Console.WriteLine("Building binary search Tree");
            foreach (int value in binaryTree)
            {
                if (root == null)
                {
                    Console.WriteLine("Initializing the root node with value: {0}", value.ToString());
                    root = new Node(value);
                }
                else
                {
                    Console.WriteLine("Inserting Node {0}", value.ToString());
                    root = root.Insert(ref root, value);
                }
            }
            Console.WriteLine("Enter value to be deleted");
            int valueToBeDeleted = Convert.ToInt16(Console.ReadLine());
            //root = root.Delete(ref root, valueToBeDeleted);

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
