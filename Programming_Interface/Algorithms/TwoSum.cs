using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Interface.Algorithms
{
    internal class TwoSum
    {
        public int[] Execute(int[] nums, int target)
        {
            int count = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                int sum = nums[count] + nums[i];
                if (target == sum && count !=i)
                {
                    return new int[] { count, i};
                }

                if(i==nums.Length-1)
                {
                    count++;
                    i=1;
                }

            }
            return new int[] { };
        }
    }
}
