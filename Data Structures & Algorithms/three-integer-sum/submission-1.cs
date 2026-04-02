public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
   			//		Input: nums = [-1, 0, 1, 2, -1, -4]
			//		sorted: [-4, -1, -1, 0, 1, 2]
			//		Output: [[-1,-1,2],[-1,0,1]]
			if (nums.Length <= 2) return new List<List<int>>();

			Dictionary<string, List<int>> keyValuePairs = new Dictionary<string, List<int>>();
			nums = nums.OrderBy(x => x).ToArray();
			int target = 0;
			int left = 0, right = 0;
			while (target <= nums.Length - 1)
			{
				left = target + 1;
				right = nums.Length - 1;
				while (left < right)
				{
					if (nums[left] + nums[right] == -nums[target])
					{
						if (!keyValuePairs.ContainsKey($"{nums[target]}{nums[left]}{nums[right]}"))
						{
							keyValuePairs.Add($"{nums[target]}{nums[left]}{nums[right]}", new List<int>() { nums[target], nums[left], nums[right] });
						}
						right -= 1;
					}
					else
					{
						if (nums[left] + nums[right] > -nums[target])
						{
							right -= 1;
						}
						else
						{
							left += 1;
						}
					}


				}
				target += 1;
			}
			return keyValuePairs.Values.Select(x => x).ToList();    
    }
}
