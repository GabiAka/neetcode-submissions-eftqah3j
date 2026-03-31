public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> numSet = new HashSet<int>(nums);
int longest = 0;

//loop từng item, kiểm tra n-1 có tồn tại hay không
//nếu không tồn tại thì bắt đầu đếm từ item đó
foreach (int num in numSet)
{
			if (!numSet.Contains(num - 1))
			{
				int length = 1;
				while (numSet.Contains(num + length))
				{
					length += 1;
				}

				longest = Math.Max(longest, length);
			}

}

return longest;
    }
}
