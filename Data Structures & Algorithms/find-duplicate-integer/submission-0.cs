public class Solution {
    public int FindDuplicate(int[] nums) {
        // Index:   0   1   2   3   4
        // Value:  [3,  1,  3,  4,  2]
        int slow = 0, fast = 0;

        // phase 1, tìm meeting point
        do {
            slow = nums[slow];
            fast = nums[nums[fast]];
        } while (slow != fast);

        // phase 2, tìm entry point
        int pointer = 0;
        do {
            pointer = nums[pointer];
            slow = nums[slow];

        } while (pointer != slow);
        return pointer;
    }
}
