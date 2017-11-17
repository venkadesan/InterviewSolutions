using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewSolutions
{
    class Program
    {
        static void Main(string[] args)
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
    }
}
