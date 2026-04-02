public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
  			int start = 0, end = numbers.Length - 1;
			while (start < end)
			{
				if (numbers[start] + numbers[end] == target) return new int[] { start + 1, end + 1 };
				if (numbers[start] + numbers[end] > target)
				{
					end -= 1;
				}
				else
				{
					start += 1;
				}

			}
			return new int[2];      
    }
}
