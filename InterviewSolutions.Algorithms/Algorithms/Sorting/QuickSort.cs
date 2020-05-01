using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewSolutions.Algorithms.Sorting
{
    public class QuickSort
    {
        public QuickSort()
        {

        }

        #region SortArray
        public int[] SortArray(int[] arr, int left, int right)
        {
            try
            {
                int pIndex = Partition(arr, left, right);
                // Sort Left Array
                if (left < pIndex - 1)
                    SortArray(arr, left, pIndex - 1);
                if (pIndex < right)
                    // Sort right Array
                    SortArray(arr, pIndex, right);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return arr;
        }
        #endregion

        #region Partition
        private int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[(left + right) / 2];
            while (left <= right)
            {
                // Find the element that should be on right of the array.
                while (arr[left] < pivot) left++;
                // Find the element that should be on the left side of the array
                while (arr[right] > pivot) right--;
                // Swap the value.
                if (left <= right)
                {
                    int temp = arr[right];
                    arr[right] = arr[left];
                    arr[left] = temp;
                    left++;
                    right--;
                }
            }
            return left;
        }

        #endregion


    }
}
