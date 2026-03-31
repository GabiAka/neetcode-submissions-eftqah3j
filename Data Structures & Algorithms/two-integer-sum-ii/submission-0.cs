public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int left = 0, right = numbers.Length - 1, sum = 0;
while (left < right)
{
			sum = numbers[left] + numbers[right];

			if (sum > target)
			{
				right -= 1;
			}
			else if (sum < target)
			{
				left += 1;
			}
			else
			{
				return new int[] { left + 1, right + 1 };
			}
}
return new int[0];
    }
}
