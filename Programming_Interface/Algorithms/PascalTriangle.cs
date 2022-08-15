using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Interface.Algorithms
{
    internal class PascalTriangle
    {
        public List<List<int>> Execute(int numRows)
        {
            List<List<int>> result =new List<List<int>>();
            List<int> arr = new List<int>();
            arr.Add(1);
            result.Add(arr);
            
            for (int i = 1; i < numRows; i++)
            {
                arr.RemoveRange(0,arr.Count);
                arr.Add(1);
                for (int j = 0; j < result[result.Count-1].Count-1; j++)
                {
                    int sum = result[result.Count - 1][j] + result[result.Count - 1][j+1];
                    arr.Add(sum);
                }
                arr.Add(1);
                result.Add(arr);
                
            }
            return result;
        }
    }
}
