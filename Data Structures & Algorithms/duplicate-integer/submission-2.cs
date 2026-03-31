public class Solution {
    public bool hasDuplicate(int[] nums) {
HashSet<int> ints = new HashSet<int>();
foreach (var num in nums)
{
			if (ints.Contains(num)) return true;
			ints.Add(num);
}
return false;
       
    }
}