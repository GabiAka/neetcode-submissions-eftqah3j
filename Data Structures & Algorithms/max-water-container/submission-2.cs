public class Solution {
    public int MaxArea(int[] heights) {
			int start = 0, end = heights.Length - 1;
			int maximum = 0;
			while (start < end)
			{
				int minHeight = Math.Min(heights[start], heights[end]);
				int distance = end - start;
				maximum = Math.Max(maximum, distance * minHeight);

				if (minHeight == heights[start]) start += 1;
				else end -= 1;
			}
			return maximum;        
    }
}
