public class Solution {
    public int BinarySearch(int l, int r, int[] nums, int target) {
        if (l > r)
            return -1;
        int m = l + (r - l) / 2;

        if (nums[m] == target)
            return m;

        if (target > nums[m]) {
            l = m + 1;
        } else {
            r = m - 1;
        }
        return BinarySearch(l, r, nums, target);
    }
    public bool SearchMatrix(int[][] matrix, int target) {
        for (int x = 0; x < matrix.Length; x++) {
            var searchTargetIndex = BinarySearch(0, matrix[x].Length - 1, matrix[x], target);
            if (searchTargetIndex >= 0 && matrix[x][searchTargetIndex] == target )
                return true;
        }
        return false;
    }
}
