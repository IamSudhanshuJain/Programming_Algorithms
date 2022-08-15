using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Interface.Algorithms
{
    internal class MoveZeroes
    {
        public void Execute(int[] nums)
        {

            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    int temp = nums[index];
                    nums[index] = nums[i];
                    nums[i] = temp;
                    index++;
                }
            }
        }
    }
}
