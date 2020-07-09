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
            // Urlify
            Urlify();
            // isRotation
            Rotation();
            //Rotate Matrix
            RotateMatrix();

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

        private static void Urlify()
        {
            var uRLify = new URLify();
            string str = "Mr John Smith    ";
            int length = 13;
            char[] chars = str.ToCharArray();
            uRLify.replaceSpaces(chars, length);
            Console.WriteLine($"After urlify {new string(chars)}");
        }

        private static void Rotation()
        {
            string s1 = "waterbottle";
            string rotatedString = "bottlewater";
            Rotation rotation = new Rotation();
            Console.WriteLine($"{rotation.IsRotation(s1, rotatedString)}");
        }

        private static void RotateMatrix()
        {
            var rotateMatrix = new RotateMatrix();
            int[,] matrix = new int[,] { { 1, 2, 3 },
                                          { 4, 5,6 },
                                          { 7, 8,9 }
                                        };

            rotateMatrix.Rotate(matrix);


        }

    }
}
