public class Solution {
    public int MaxArea(int[] heights) {
        	int l = 0, r = heights.Length - 1, res = 0;
	int area = 0;
	while (l < r)
	{
		area = (Math.Min(heights[l], heights[r])) * (r - l);
		res = Math.Max(res, area);

		if (heights[l] <= heights[r])
		{
			l++;
		}
		else
		{
			r--;
		}



	}
	return res;
    }
}
