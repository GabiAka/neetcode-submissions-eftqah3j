public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] preffix = new int[nums.Length];
int[] suffix = new int[nums.Length];

//loop từ trái sang phải
int current = 0;
for (int i = 0; i < nums.Length; i++)
{
			if (i == 0)
			{
				preffix[i] = 1;
				current = nums[i];
			}
			else
			{
				preffix[i] = current;
				current = current * nums[i];
			}
}

//loop từ phải sang trái
current = 0;
for (int i = nums.Length - 1; i >= 0; i--)
{
			if (i == nums.Length - 1)
			{
				suffix[i] = 1;
				current = nums[i];
			}
			else
			{
				suffix[i] = current;
				current = current * nums[i];
			}
}

//loop ra 1 array mới
int[] res = new int[nums.Length];
for (int i = 0; i < nums.Length; i++)
{
			int pref = preffix[i];
			int suf = suffix[i];
			res[i] = pref * suf;
}

return res;
    }
}
