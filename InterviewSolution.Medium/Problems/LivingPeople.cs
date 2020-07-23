using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolution.Medium.Problems
{
    public class LivingPeople
    {
        public int GetMaxAliveYear(People[] peoples, int min,int max)
        {
            int[] popDetals = GetPopulationDeltas(peoples, min, max);
            int maxAliveyear = GetMaxAliveYear(popDetals);
            return maxAliveyear + min;
        }

        private int GetMaxAliveYear(int[] deltas)
        {
            int maxAliveYear = 0;
            int maxAlive = 0;
            int currentlyAlive = 0;
            for (int year = 0; year < deltas.Length; year++)
            {
                currentlyAlive += deltas[year];
                if (currentlyAlive > maxAlive)
                {
                    maxAliveYear = year;
                    maxAlive = currentlyAlive;
                }

            }
            return maxAliveYear;
        }

        public int[] GetPopulationDeltas(People[] peoples, int min, int max)
        {
            int[] populationDeltas = new int[(max - min) + 2];
            foreach (var people in peoples)
            {
                int birth = people.birthYear - min;
                populationDeltas[birth]++;

                int death = people.deathYear - min;
                populationDeltas[death + 1]--;
            }
            return populationDeltas;
        }

    }

    public class People
    {
        public int birthYear { get; set; }
        public int deathYear { get; set; }

        public People(int _birthYear, int _deathYear)
        {
            birthYear = _birthYear;
            deathYear = _deathYear;
        }
    }
}
