public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        int n = nums.Length;
        int l = 0, r = 0;
        LinkedList<int> q = new LinkedList<int>();
        int[] res = new int[n - k + 1];

        while (r < n) {
            while (q.Count > 0 && nums[q.Last.Value] < nums[r]) {
                q.RemoveLast();
            }

            q.AddLast(r);

            if (q.First.Value < l) {
                q.RemoveFirst();
            }

            if ((r + 1) >= k) {
                res[l] = nums[q.First.Value];
                l++;
            }
            r++;
        }

        return res;
    }
}
