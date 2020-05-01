#region NameSpace
using System;
using System.Collections.Generic;
using System.Linq;
#endregion


namespace InterviewSolutions
{
    class Program
    {
        static void Main(string[] args)
        {

            //int maxPosition = 10;
            //int[] start = new int[] { 3, 8 };
            //int[] end = new int[] { 4, 9 };
            //int result = widestGap(maxPosition, start, end);


        }


        private static int[] getMaxElementIndices(int[] a, int[] rotate)
        {
            List<int> rotatedResults = new List<int>();
            try
            {
                for (int rotateLength = 0; rotateLength < rotate.Length; rotateLength++)
                {

                    Queue<int> q = new Queue<int>(a);
                    Stack<int> s;
                    int rotateValue = rotate[rotateLength];
                    while (rotateValue > 0)
                    {
                        s = new Stack<int>(q);
                        int x = s.Pop();
                        s = new Stack<int>(s);
                        s.Push(x);
                        q = new Queue<int>(s);
                        rotateValue--;

                    }
                    var result = q.ToArray();
                    int maxValue = result.Max();
                    int maxIndex = result.ToList().IndexOf(maxValue);
                    rotatedResults.Add(maxIndex);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return rotatedResults.ToArray();
        }


        private static int widestGap(int n, int[] start, int[] end)
        {
            int gap = 0;
            if (n > 0 && start.Length > 0 && end.Length > 0 && start.Length == end.Length)
            {
                List<int> road = new List<int>(n);
                int totalNoOfCars = start.Length;
                List<int> lstofGaps = new List<int>();
                Queue<int> startQ = new Queue<int>(start);
                Queue<int> endQ = new Queue<int>(end);

                int startPosition = startQ.Dequeue();
                int endPosition = endQ.Dequeue();
                for (int position = 1; position <= road.Capacity; position++)
                {
                    if (endPosition > position || position > endPosition)
                    {
                        //car startPosition
                        if (startPosition != position && endPosition != position)
                        {
                            gap++;
                        }
                    }
                    else
                    {
                        lstofGaps.Add(gap);
                        gap = 0;
                        if (startQ.Count > 0)
                        {
                            startPosition = startQ.Dequeue();
                            endPosition = endQ.Dequeue();
                        }
                    }
                }


                int maxValue = lstofGaps.ToArray().Max();
            }
            return gap;

        }
    }



}


