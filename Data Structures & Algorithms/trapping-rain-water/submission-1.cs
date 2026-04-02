public class Solution {
    public int Trap(int[] height) {
  	int left = 0, right = height.Length - 1;
	int maxLeft = height[left], maxRight = height[right];
	int sumHeight = 0;
	int currentBlock = left;

	while (left < right)
	{
		int waterBlock = Math.Min(maxLeft, maxRight) - height[currentBlock];
		if (waterBlock > 0) sumHeight += waterBlock;

		if (height[left] <= height[right])
		{
			left++;
			currentBlock = left;
			maxLeft = Math.Max(maxLeft, height[left]);
		}
		else
		{
			right--;
			currentBlock = right;
			maxRight = Math.Max(maxRight, height[right]);

		}
	}
	return sumHeight;      
    }
}
