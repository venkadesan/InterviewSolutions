using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewSolutions.Algorithms.Sorting
{
    public class MergeSort
    {
        #region Constructor
        public MergeSort()
        { }
        #endregion

        #region Sort
        /// <summary>
        /// Public Method for sorting array.
        /// </summary>
        /// <param name="arr">array to be sorted</param>
        /// <param name="low">lower index</param>
        /// <param name="high">higher index</param>
        /// <returns></returns>
        public int[] Sort(int[] arr, int low, int high)
        {
            int[] helper = new int[arr.Length];
            MergeSorting(arr, helper, low, high);
            return arr;
        }

        #endregion

        #region MergeSorting
        /// <summary>
        ///  Implemenation of merge sorting algorithm.
        /// </summary>
        /// <param name="array">array to be sorted</param>
        /// <param name="helper">helper array</param>
        /// <param name="low">lower index</param>
        /// <param name="high">higher index</param>
        private void MergeSorting(int[] array, int[] helper, int low, int high)
        {
            if (low < high)
            {
                int middle = (low + high) / 2;
                MergeSorting(array, helper, low, middle);
                MergeSorting(array, helper, middle + 1, high);
                Merge(array, helper, low, middle, high);

            }
        }

        #endregion

        #region Merge
        /// <summary>
        /// Compares and merge the array from helper array 
        /// </summary>
        /// <param name="array">array to be sorted</param>
        /// <param name="helper">Aux array - helper array for sorting comparison</param>
        /// <param name="low">lower index</param>
        /// <param name="middle">Middle Index</param>
        /// <param name="high">higher index</param>
        private void Merge(int[] array, int[] helper, int low, int middle, int high)
        {
            // copy both halves into helper array
            for (int i = low; i <= high; i++)
            {
                helper[i] = array[i];
            }
            int helperLeft = low;
            int helperRight = middle + 1;
            int current = low;
            //Iterate through helper array. Compare the left and right half, copying back
            // the smaller element from the two halves into the original array.
            while (helperLeft <= middle && helperRight <= high)
            {
                if (helper[helperLeft] <= helper[helperRight])
                {
                    array[current] = helper[helperLeft];
                    helperLeft++;
                }
                else
                {
                    //If right element is smaller than left element
                    array[current] = helper[helperRight];
                    helperRight++;
                }
                current++;

            }

            /* Copy the rest of the left side of the array into the target array*/
            int remaining = middle - helperLeft;
            for (int i = 0; i <= remaining; i++)
            {
                array[current + i] = helper[helperLeft + i];
            }
        }

        #endregion

    }
}
