using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Interface.Algorithms
{
    internal class PlusOne
    {
        public int[] Execute(int[] digits)
        {
            int i=0;
            int [] result=new int[digits.Length + 1];   
            for (i = digits.Length-1; i >=0; i--)
            {
                if (digits[i] != 9)
                {
                    digits[i] += 1;
                    return digits;
                }
                else
                    digits[i] = 0;
            }
            if(i==-1)
            {
                result[0] = 1;
            }
            return result;
        }
    }
}
