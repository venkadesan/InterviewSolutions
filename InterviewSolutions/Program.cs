using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterviewSolutions.Tree;


namespace InterviewSolutions
{
    class Program
    {
        static void Main(string[] args)
        {

            Tree();
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
            root = root.Delete(ref root, valueToBeDeleted);

        }
    }
}
