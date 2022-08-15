using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Interface.Algorithms
{
    internal class SearchInsertPosition
    {
        public int Execute(int[] nums, int target)
        {

            int i = 0;
            for (i = 0; i < nums.Length; i++)
            {
                if (target == nums[i])
                    return i;
                if (target < nums[i])
                    return i;
            }
            return i;
        }
    }
}
