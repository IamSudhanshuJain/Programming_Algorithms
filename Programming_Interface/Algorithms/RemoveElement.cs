using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Interface.Algorithms
{
    internal class RemoveElement
    {
        public int Execute(int[] nums, int val)
        {
            int readIndex = 0;
            int writeIndex = 0;
            
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val)
                {
                    readIndex++;
                }
                else
                {
                    nums[writeIndex] = nums[readIndex];
                    writeIndex++;
                    readIndex++;
                }
            }

            return writeIndex;
        }
    }
}
