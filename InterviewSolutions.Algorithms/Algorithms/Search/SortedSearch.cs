using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolutions.Algorithms.Search
{
    public class SortedSearch
    {
        public int search(Listy list, int value)
        {
            int index = 1;
            while (list.elementAt(index) != -1 && list.elementAt(index) < value)
            {
                index *= 2;
            }
            return BinarySearch(list, value, index / 2, index);
        }

        private int BinarySearch(Listy list, int value, int low, int high)
        {
            int mid;
            while (low <= high)
            {
                mid = (low + high) / 2;
                int middle = list.elementAt(mid);
                if (middle > value || middle == -1)
                {
                    high = mid - 1;
                }
                else if (middle < value)
                {
                    low = mid + 1;
                }
                else
                {
                    return mid;
                }
            }
            return -1;
        }
    }

    public class Listy
    {

        public List<int> numbers { get; set; }

        public Listy()
        { }
        public Listy(List<int> _numbers)
        {
            numbers = _numbers;
        }

        public int elementAt(int i)
        {
            if (numbers.Count >= i)
                return numbers[i];
            else
                return -1;
        }
    }
}
