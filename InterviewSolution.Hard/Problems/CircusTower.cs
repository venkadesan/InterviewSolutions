using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolution.Hard.Problems
{
    public class CircusTower
    {

        #region public methods

        #region GetLongestSequence
        public List<HeightWeight> GetLongestSequeuence(List<HeightWeight> heightWeights)
        {
            heightWeights.Sort();// Sorting by default comparison
            var solutions = new List<List<HeightWeight>>();
            List<HeightWeight> bestSequence = null;
            for (int i = 0; i < heightWeights.Count; i++)
            {
                var longestAtIndex = BestSequenceAtIndex(heightWeights, solutions, i);
                solutions.Add(longestAtIndex);
                bestSequence = MaxSequence(bestSequence, longestAtIndex);
            }
            return bestSequence;
        }
        #endregion

        #endregion


        #region private methods

        #region BestSequenceAtIndex
        List<HeightWeight> BestSequenceAtIndex(List<HeightWeight> heightWeights, List<List<HeightWeight>> solutions, int index)
        {
            var bestSequence = new List<HeightWeight>();
            if (heightWeights != null && heightWeights.Count > 0)
            {
                var hwt = heightWeights[index];
                for (int i = 0; i < index; i++)
                {
                    var solution = solutions[i];
                    if (CanAppend(hwt, solution))
                    {
                        bestSequence = MaxSequence(solution, bestSequence);
                    }
                }

                var clonedArray = new HeightWeight[] { };
                bestSequence.CopyTo(clonedArray);
                var best = new List<HeightWeight>(clonedArray);
                best.Add(hwt);
                return best;
            }
            return null;
        }
        #endregion

        #region MaxSequence
        private List<HeightWeight> MaxSequence(List<HeightWeight> seq1, List<HeightWeight> seq2)
        {
            if (seq1 == null)
            {
                return seq2;
            }
            if (seq2 == null)
            {
                return seq1;
            }
            return seq1.Count > seq2.Count ? seq1 : seq2;
        }
        #endregion

        #region CanAppend
        private bool CanAppend(HeightWeight other, List<HeightWeight> solution)
        {
            if (solution == null) return false;
            if (solution.Count == 0) return true;
            var last = solution[solution.Count - 1];
            return last.ISBefore(other);
        }

        #endregion

        #endregion

    }

    #region HeightWeight

    public class HeightWeight : IComparable<HeightWeight>
    {

        #region properties
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        #endregion

        #region constructor
        public HeightWeight(decimal height, decimal weight)
        {
            Height = height;
            Weight = weight;
        }
        #endregion

        #region CompareTo
        public int CompareTo(HeightWeight other)
        {
            if (Height != other.Height)
            {
                return Height.CompareTo(other.Height);
            }
            else
            {
                return Weight.CompareTo(other.Weight);
            }
        }
        #endregion

        #region IsBefore
        public bool ISBefore(HeightWeight other)
        {
            if (Height < other.Height && Weight < other.Weight)
            {
                return true;
            }
            return false;
        }
        #endregion

    }
    #endregion

}
