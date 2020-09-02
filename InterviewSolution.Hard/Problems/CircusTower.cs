using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolution.Hard.Problems
{
    public class CircusTower
    {
        public List<HeightWeight> GetLongestSequeuence(List<HeightWeight> heightWeights)
        {
            var longestWeight = new List<HeightWeight>();

            return longestWeight;
        }
    }

    #region HeightWeight

    public class HeightWeight : IComparable<HeightWeight>
    {
        public decimal Height { get; set; }
        public decimal Weight { get; set; }

        #region constructor
        public HeightWeight(decimal height, decimal weight)
        {
            Height = height;
            Weight = weight;
        }
        #endregion


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
    }
    #endregion

}
