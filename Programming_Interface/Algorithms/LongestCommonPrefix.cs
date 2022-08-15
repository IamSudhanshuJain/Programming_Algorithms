using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Interface.Algorithms
{
    internal class LongestCommonPrefix
    {
     /// <summary>
     /// [flower, flow, flask] ==> [flow, flask, flower] => fl
     /// </summary>
     /// <param name="strs"></param>
     /// <returns></returns>

        public string Execute(string[] strs)
        {
            string res = "";
            for (int i = 0; i < strs[0].Length; i++)
            {
                for (int j = 0; j < strs.Length; j++)
                {
                    if (i == strs[j].Length || strs[j][i] != strs[0][i])
                        return res;

                }
                res = res + strs[0][i];
            }
            return res;
        }
    }
}
