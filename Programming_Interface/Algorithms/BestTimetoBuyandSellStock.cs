using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Interface.Algorithms
{
    internal class BestTimetoBuyandSellStock
    {
        public int Execute(int[] prices)
        {
            int minimumPrice = prices[0];
            int maxProfit = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                int profit = prices[i] - minimumPrice;
                if (minimumPrice>prices[i])
                {
                    minimumPrice = prices[i];
                }
                if(maxProfit<profit)
                {
                    maxProfit = prices[i]-minimumPrice;
                }
            }
            return maxProfit;

        }
       
    }
}
