public class Solution {
    public int BinarySearch(int l, int r, int[] nums, int target) {
        if (l > r) {
            return -1;
        }
        int m = l + (r - l) / 2;
        if (nums[m] == target)
            return m;

        return target > nums[m]? BinarySearch(m + 1, r, nums, target)
            : BinarySearch(l, m - 1, nums, target);
    }

    public int Search(int[] nums, int target) {
        return BinarySearch(0, nums.Length - 1, nums, target);
    }
}
