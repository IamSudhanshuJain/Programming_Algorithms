using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Interface.Algorithms
{
    internal class RomanToInteger
    {
        /// <summary>
        /// Symbol       Value
        //  I             1
        //  V             5
        //  X             10
        //  L             50
        //  C             100
        //  D             500
        //  M             1000
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>

        public int Execute(string s)
        {
            char[] splitRoman = s.ToCharArray();
            Dictionary<char, int> romans = new Dictionary<char, int>();
            romans.Add('I', 1);
            romans.Add('V', 5);
            romans.Add('X', 10);
            romans.Add('L', 50);
            romans.Add('C', 100);
            romans.Add('D', 500);
            romans.Add('M', 1000);

            int sum = 0;
            for (int i = 0; i < splitRoman.Length; i++)
            {
                int difference = 0;
                if (i <splitRoman.Length-1 && romans[splitRoman[i + 1]] > romans[splitRoman[i]])
                {
                    difference = romans[splitRoman[i + 1]] - romans[splitRoman[i]];
                    sum = sum + difference;
                    i++;
                }
                else
                {
                    sum = sum + romans[splitRoman[i]];
                }
            }
            return sum;
        }
    }
}
