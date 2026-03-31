public class Solution {
    public bool hasDuplicate(int[] nums) {
	int numLength = nums.Length;
	Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
	foreach (var num in nums)
	{
		if (keyValuePairs.ContainsKey(num)) keyValuePairs[num]++;
		else keyValuePairs.Add(num, 1);
	}

	foreach (var item in keyValuePairs)
	{
		if (item.Value > 1) return true;
	}
	return false;
       
    }
}