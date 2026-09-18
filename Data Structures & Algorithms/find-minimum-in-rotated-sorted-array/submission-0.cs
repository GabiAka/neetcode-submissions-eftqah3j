public class Solution {
    public int FindMin(int[] nums) {
        // Input: nums = [3,4,5,6,1,2]
        // Output: 1

        int l = 0, r = nums.Length - 1;
        while (l < r) {
            int m = l + (r - l) / 2;
            Console.WriteLine(m);

            if (nums[m] < nums[r]) {
                r = m;
            } else {
                l = m + 1;
            }
        }

        return nums[l];
    }
}
