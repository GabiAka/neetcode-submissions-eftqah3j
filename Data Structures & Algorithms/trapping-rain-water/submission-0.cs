public class Solution {
    public int Trap(int[] height) {
			int totalWater = 0;
			for (int i = 0; i < height.Length; i++)
			{
				int maxLeft = 0, maxRight = 0;

				//bên trái
				for (int x = 0; x < i; x++)
				{
					maxLeft = Math.Max(maxLeft, height[x]);
				}

				//bên phải
				for (int x = i + 1; x < height.Length; x++)
				{
					maxRight = Math.Max(maxRight, height[x]);
				}

				//cộng
				int res = Math.Min(maxLeft, maxRight) - height[i];
				totalWater += res >= 0 ? res : 0;
			}
			return totalWater;        
    }
}
