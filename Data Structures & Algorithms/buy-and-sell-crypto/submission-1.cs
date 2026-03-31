public class Solution {
    public int MaxProfit(int[] prices) {
			int left = 0, right = 1;
			int maxP = 0;
			while (right < prices.Length)
			{
				if (prices[left] < prices[right])
				{
					maxP = Math.Max(maxP, prices[right] - prices[left]);
				}
				else
				{
					left = right;
				}
				right++;
			}
			return maxP;    
    }
}
