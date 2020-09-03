using System;
using InterviewSolution.Hard.Problems;
using System.Collections.Generic;
namespace InterviewSolution.Hard
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Adding without Plus
            AddingWithoutPlus();
            //2. Shuffle Array
            ShuffleArray();
            //3. Random Set
            RandomSet();
            //4. Letters and Numbers
            LettersAndNumbers();
            //5. count of 2s in range
            CountOf2InRange();
            //6. Baby names
            BabyNames();
            // 7.Circus Tower
            CirCusTower();
            //8. Kth Multiple.
            KthMultiple();
        }

        private static void AddingWithoutPlus()
        {
            var add = new AddWithoutPlus();
            int a = 525;
            int b = 799;
            Console.WriteLine($"Adding without Plus Symobl {add.Add(a, b)}");
        }

        private static void ShuffleArray()
        {
            var shuffleArray = new Shuffle();
            var array = new int[52];
            for (int i = 1; i <= 52; i++)
            {
                array[i - 1] = i;
            }
            shuffleArray.ShuffleArray(array);
        }

        private static void RandomSet()
        {
            var randomSet = new RandomSet();
            var original = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int m = 5;
            var result = randomSet.PickMInIteratively(original, m);
            if (result != null && result.Length > 0)
            {
                foreach (var num in result)
                {
                    Console.WriteLine($"Random set {num}");
                }
            }
        }

        private static void LettersAndNumbers()
        {
            var lettersAndNumbers = new LettersAndNumbers();
            char[] array = new char[] { 'A', 'B', 'A', 'A', 'A', 'B', 'B', 'B', 'A' };
            var subArray = lettersAndNumbers.FindLongestSubArray(array);
            if (subArray?.Length > 0)
            {
                foreach (var sArr in subArray)
                {
                    Console.WriteLine($"LongestSubArray: {sArr}");
                }
            }
        }


        private static void CountOf2InRange()
        {
            var countOf2S = new CountOf2s();
            int number = 100;
            Console.WriteLine($" {countOf2S.Count2sInRange(number)}");
        }

        private static void BabyNames()
        {
            var babyNames = new BabyNames();
            var names = new Dictionary<string, int>();
            names.Add("John", 15);
            names.Add("Jon", 12);
            names.Add("Chris", 13);
            names.Add("Kris", 4);
            names.Add("Christopher", 19);

            var synonyms = new List<BabyNames.Synonym>();
            synonyms.Add(new BabyNames.Synonym("Jon", "John"));
            synonyms.Add(new BabyNames.Synonym("John", "Johnny"));
            synonyms.Add(new BabyNames.Synonym("Chris", "Kris"));
            synonyms.Add(new BabyNames.Synonym("Chris", "Christopher"));
            var popularNames = babyNames.TrulyMostPopular(names, synonyms);
            if (popularNames != null && popularNames.Count > 0)
            {
                foreach (var name in popularNames)
                {
                    Console.WriteLine($"Name:{name.Key}, Key: {name.Value}");
                }

            }
        }


        private static void CirCusTower()
        {
            var tower = new CircusTower();
            var persons = new List<HeightWeight>() {
                 new HeightWeight(5.5m,80.1m),
                 new HeightWeight(5.2m,70.1m),
                 new HeightWeight(5.3m,90.1m),
                 new HeightWeight(5.4m,80.1m),
                 new HeightWeight(6.0m,94.1m),
                new HeightWeight(6.2m,95.1m),
                new HeightWeight(5.0m,70.1m),
            };
            var longestTower = tower.GetLongestSequeuence(persons);
            if (longestTower?.Count > 0)
            {
                foreach (var person in longestTower)
                {
                    Console.WriteLine($" Height:{person.Height}, Weight : {person.Weight}");
                }
            }
        }


        private static void KthMultiple()
        {
            var kthMultipe = new KthMultiple();
            var number = 4;
            Console.WriteLine($"{kthMultipe.GetKthMultiple(number)}");
        }

    }
}
