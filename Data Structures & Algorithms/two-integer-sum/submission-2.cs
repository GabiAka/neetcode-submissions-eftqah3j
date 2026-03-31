public class Solution {
		public  int[] TwoSum(int[] nums, int target)
		{
			//convert sang hashmap
Dictionary<int, int> indices = new Dictionary<int, int>();
for (int i = 0; i < nums.Length; i++)
{
			indices[nums[i]] = i;
}

int remain = 0;
for (int i = 0; i < nums.Length; i++)
{
			int num = nums[i];
			remain = target - num;

			if (indices.ContainsKey(remain) && indices[remain] != i)
			{
				return new int[] { i, indices[remain] };
			}
			remain = 0;
}
return new int[0];
		}
}
