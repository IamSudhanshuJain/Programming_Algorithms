using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Interface.Algorithms
{
    internal class PalindromeNumber
    {
        public bool Execute(int x)
        {
            if (x < 0)
                return false;
            int reverse = 0;
            int original = x;
            while (x != 0)
            {
                int rem = x % 10;
                reverse = reverse * 10 + rem;
                x = x / 10;
            }
            if (reverse == original)
                return true;

            return false;
        }       
    }
}
