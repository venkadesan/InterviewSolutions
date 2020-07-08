using System;
using System.Collections.Generic;
using InterviewSolutions.Array.StringProblems;

namespace InterviewSolutions.Array
{
    class Program
    {
        static void Main(string[] args)
        {


            // Palindrome
            Plaindrome();
            // one Way
            OneAway();
            // Compress String problem
            CompressString();
            // isUnique
            isUnique();

            // is Permutation
            isPermutation();

        }


        private static void Plaindrome()
        {
            Console.WriteLine("Is a Palindrome");
            Palindrome pal = new Palindrome();
            string palindromCharacter = Console.ReadLine();
            List<string> lstOfPermutations = new List<string>();
            lstOfPermutations.Add(palindromCharacter);
            pal.isPermuationPalindrome(palindromCharacter);
            if (pal.isPermuationPalindrome(palindromCharacter))
            {
                Console.WriteLine(String.Format("The input character is a Palindrome {0}", palindromCharacter));
                Console.Read();
            }

        }


        private static void OneAway()
        {
            OneAway oAway = new OneAway();
            if (oAway.oneEditAway("pale", "pae"))
                Console.Write("Both Strings are one edit away");
            else
                Console.Write("Both Strings are Not one Edit Away");

            if (oAway.oneEditAwayVersion1("pale", "ble"))
            {
                Console.Write("Both Strings are one edit away");
            }
            else
                Console.Write("Both Strings are Not one Edit Away");
        }


        private static void CompressString()
        {
            // String compression problem.
            CompressString str = new CompressString();
            string strToProcess = "aabccccccaaa";
            var compressed = str.Compress(strToProcess);

        }


        private static void isUnique()
        {
            UniqueChars unique = new UniqueChars();
            string str = "abcdefghig";
            Console.WriteLine($" {unique.isUniqueChars(str)}");
            Console.WriteLine($"{unique.isUniqueChars2(str)}");

        }

        private static void isPermutation()
        {
            Permutation perm = new Permutation();
            string s1 = "abc";
            string s2 = "cab";

            Console.WriteLine($"{perm.IsPermutation(s1, s2)}");
        }

    }
}
