using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolutions.Algorithms.Search
{
    public class RotatedArray
    {
        public int search(int[] a, int left, int right, int x)
        {
            int mid = (left + right) / 2;
            if (x == a[mid]) // found element
            {
                return mid;
            }
            if (right < left)
            {
                return -1;
            }

            if (a[left] < a[mid])
            {
                if (x >= a[left] && x < a[mid])
                {
                    return search(a, left, mid - 1, x);
                }
                else
                {
                    return search(a, mid + 1, right, x);
                }
            }
            else if (a[mid] < a[left]) // right is ordered. 
            {
                if (x > a[mid] && x <= a[right])
                {
                    return search(a, mid + 1, right, x); //search right
                }
                else
                {
                    return search(a, left, mid - 1, x); // Search left
                }
            }
            else if (a[left] == a[mid])
            {
                if (a[mid] != a[right])
                {
                    return search(a, mid + 1, right, x);
                }
                else
                {
                    int result = search(a, left, mid = -1, x);
                    if (result == -1)
                    {
                        return search(a, mid + 1, right, x);
                    }
                    else
                    {
                        return result;
                    }
                }
            }
            return -1;
        }
    }
}
