using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace InterviewSolutions.Algorithms.Search
{
    public class Duplicates
    {

        public void checkDuplicates(int[] array,int size)
        {
            BitSet bs = new BitSet(size);
            for (int i = 0; i < array.Length; i++)
            {
                int num = array[i];
                int num0 = num - 1;
                if (bs.get(num0))
                {
                    Console.WriteLine(num);
                }
                else
                {
                    bs.set(num0);
                }

            }
        }


        public class BitSet
        {
            int[] bitSet;

            public BitSet(int size)
            {
                bitSet = new int[(size >> 5) + 1];
            }

            public bool get(int pos)
            {
                int wordNumber = (pos >> 5);
                int bitnumber = (pos & 0x1F);
                return (bitSet[wordNumber] & (1 << bitnumber)) != 0;
            }

            public void set(int pos)
            {
                int wordNumber = (pos >> 5);
                int bitNumber = (pos & 0x1F);
                bitSet[wordNumber] |= 1 << bitNumber;
            }
        }
    }
}
