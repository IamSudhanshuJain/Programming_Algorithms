using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Interface.Algorithms
{
    internal class ValidParentheses
    {
        public bool Execute(string s)
        {
            int count = 0;
            while (s.Length != count)
            {
                count = s.Length;
                s = s.Replace("()", "");
                s = s.Replace("{}", "");
                s = s.Replace("[]", "");
            }
            if (s.Length == 0)
                return true;

            return false;
        }
    }
}
