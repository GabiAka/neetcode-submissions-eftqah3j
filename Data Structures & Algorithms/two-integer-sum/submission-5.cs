public class Solution {
    public int[] TwoSum(int[] nums, int target) {
			Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
			for (int i = 0; i < nums.Length; i++)
			{
				 keyValuePairs.Add(i, nums[i]);
			}

			for (int i = 0; i < keyValuePairs.Count; i++)
			{
				var start = keyValuePairs.ElementAt(i);
				for (int y = i + 1; y < keyValuePairs.Count; y++)
				{
					var cur = keyValuePairs.ElementAt(y);
					if (start.Value + cur.Value == target) return new int[2] { start.Key, cur.Key };
				}
			}

			return new int[2];
    }
}
