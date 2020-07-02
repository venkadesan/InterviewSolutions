using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolutions.Algorithms.Search
{
    public class GroupAnagrams
    {

        #region GroupAnagrams
        public void Sort(string[] array)
        {
            Dictionary<string, List<string>> mapList = new Dictionary<string, List<string>>();
            if (array != null && array.Length > 0)
            {
                foreach (string s in array)                                                                                                                        
                {
                    string key = sortChars(s);
                    if (!mapList.ContainsKey(key))
                    {
                        var list = new List<string>();
                        list.Add(s);
                        mapList.Add(key, list);
                    }
                    else
                    {
                        mapList[key].Add(s);
                    }

                }
                int index = 0;
                foreach (var key in mapList.Keys)
                {
                    List<string> list = mapList[key];
                    if (list != null && list.Count > 0)
                    {
                        foreach (string t in list)
                        {
                            array[index] = t;
                            index++;
                        }
                    }

                }
            }
        }
        #endregion


        private string sortChars(string s)
        {
            char[] contents = s.ToCharArray();
            Array.Sort(contents);
            return new string(contents);
        }
    }
}
