using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Interface.Algorithms
{
    internal class PalindromeFixedLength
    {
        public long[] Execute(int[] queries, int intLength)
        {
            int halfLength = (intLength + 1) / 2;

            long left = Convert.ToInt64(Math.Pow(10, halfLength - 1));
            long right = Convert.ToInt64(Math.Pow(10, halfLength) - 1);
            List<long> result = new List<long>();


            int reverse = halfLength;
            if (intLength % 2 != 0)
                reverse = halfLength - 1;

            long totalCount = right - left + 1;
            for (int i = 0; i < queries.Length; i++)
            {
                if (queries[i] <= totalCount)
                {
                    var leftValue = (left + queries[i] - 1).ToString();
                    string rightValue = string.Empty;
                    for (int j = reverse - 1; j >= 0; j--)
                    {
                        rightValue += leftValue[j];
                    }
                    leftValue += rightValue;
                    result.Add(long.Parse(leftValue));
                }
                else
                { result.Add(-1); }
            }

            return result.ToArray();
        }
    }
}
