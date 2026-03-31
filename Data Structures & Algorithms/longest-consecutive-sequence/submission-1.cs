public class Solution {
    public int LongestConsecutive(int[] nums) {
 HashSet<int> ints = new HashSet<int>(nums);
int longest = 0;
for (int i = 0; i < nums.Length; i++)
{
			int num = nums[i];
			int length = 0;

			if (!ints.Contains(num - 1))
			{
				while (ints.Contains(num + length))
				{
					length += 1;
				}
				longest = Math.Max(length, longest);
			}
}
return longest;       
    }
}
