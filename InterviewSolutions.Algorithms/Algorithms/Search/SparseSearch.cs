using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolutions.Algorithms.Search
{
    public class SparseSearch
    {

        #region SparseSearch
        public int Search(string[] strings, string str)
        {
            if (strings == null || string.IsNullOrWhiteSpace(str))
            {
                return -1;
            }
            return Search(strings, str, 0, strings.Length - 1);
        }
        #endregion

        private int Search(string[] strings, string str, int first, int last)
        {
            if (first > last) return -1;

            int mid = (last + first) / 2;

            if (string.IsNullOrEmpty(strings[mid]))
            {
                int left = mid - 1;
                int right = mid + 1;

                while (true)
                {
                    if (left < first && right > last)
                    {
                        return -1;
                    }
                    else if (right <= last && !string.IsNullOrEmpty(strings[right]))
                    {
                        mid = right;
                        break;
                    }
                    else if (left >= right && !string.IsNullOrEmpty(strings[left]))
                    {
                        mid = left;
                        break;
                    }
                    right++;
                    left--;
                }
            }
            if (str.Equals(strings[mid]))
            {
                return mid;
            }
            else if (strings[mid].CompareTo(str) < 0)
            {
                return Search(strings, str, mid + 1, last);
            }
            else
            {
                return Search(strings, str, first, mid - 1);
            }

        }
    }
}
