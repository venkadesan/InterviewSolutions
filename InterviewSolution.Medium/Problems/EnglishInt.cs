using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolution.Medium.Problems
{
    public class EnglishInt
    {
        string[] smalls = new string[] { "Zero","One", "Two","Three", "Four", "Five","Six","Seven",
                                          "Eight","Nine","Ten","Eleven","Twelve","Thirteen","Fourteen","Fifteen","Sixteen","Seventeen","Eighteen","Nineteen"};
        string[] tens = new string[] { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
        string[] bigs = new string[] { "", "Thousand", "Million", "Billion" };

        string hundred = "Hundred";
        string negative = "Negative";

        public string Convert(int num)
        {
            if (num == 0)
            {
                return smalls[0];
            }
            else if (num < 0)
            {
                return negative + "" + Convert(-1 * num);
            }

            LinkedList<string> parts = new LinkedList<string>();
            int chunkCount = 0;
            while (num > 0)
            {
                if (num % 1000 != 0)
                {
                    string chunk = convertChunk(num%1000) + "" +  bigs[chunkCount];
                    parts.AddFirst(chunk);
                }
                num /= 1000;
                chunkCount++;
            }

            return listToString(parts);
        }

        private string convertChunk(int number)
        {
            LinkedList<string> parts = new LinkedList<string>();
            if (number >= 100)
            {
                parts.AddFirst(smalls[number / 100]);
                parts.AddFirst(hundred);
                number %= 100;
            }

            // Converting tens places
            if (number >= 10 && number <= 19)
            {
                parts.AddLast(smalls[number]);
            }
            else if (number >= 20)
            {
                parts.AddLast(tens[number / 10]);
                number %= 10;
            }

            return listToString(parts);
        }

        private string listToString(LinkedList<string> parts)
        {
            StringBuilder sb = new StringBuilder();
            if (parts != null && parts.Count > 0)
            {
                while (parts.Count > 1)
                {
                    sb.Append(parts.First.Value);
                    parts.RemoveFirst();
                    sb.Append(" ");
                }
                sb.Append(parts.First.Value);
                parts.RemoveFirst();
                return sb.ToString();
            }
            return string.Empty;
        }

    }
}
