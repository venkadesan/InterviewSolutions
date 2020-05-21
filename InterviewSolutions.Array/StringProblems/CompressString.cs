using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewSolutions
{
    class CompressString
    {

        #region Compress
        public string Compress(string str)
        {
            int finalLength = countCompression(str);
            if (finalLength >= str.Length)
            {
                return str;
            }
            StringBuilder compressed = new StringBuilder(finalLength);
            int countConsecutive = 0;
            for (int i = 0; i < str.Length; i++)
            {
                countConsecutive++;
                if (i + 1 >= str.Length || str[i] != str[i + 1])
                {
                    compressed.Append(str[i]);
                    compressed.Append(countConsecutive);
                    countConsecutive = 0;
                }
            }

            return compressed.ToString();
        }
        #endregion


        #region countCompression
        private int countCompression(string str)
        {

            int compressedLength = 0;
            int countConsecutive = 0;

            for (int i = 0; i < str.Length; i++)
            {
                countConsecutive++;
                if (i + 1 >= str.Length || str[i] != str[i + 1])
                {
                    compressedLength = compressedLength + 1 + Convert.ToString(countConsecutive).Length;
                    countConsecutive = 0;
                }
            }
            return compressedLength;
        }

        #endregion

    }
}
