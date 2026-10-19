public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int[] A = nums1;
        int[] B = nums2;

        if (nums1.Length > nums2.Length) {
            A = nums2;
            B = nums1;
        }

        int total = A.Length + B.Length;
        int half = total / 2;

        int l = 0, r = A.Length;

        while (l <= r) {
            int i = l + (r-l) / 2;
            int j = half - i;

            int Aleft = i > 0 ? A[i - 1] : int.MinValue;
            int Aright = i < A.Length ? A[i] : int.MaxValue;
            int Bleft = j > 0 ? B[j - 1] : int.MinValue;
            int Bright = j < B.Length ? B[j] : int.MaxValue;

            if (Aleft <= Bright && Bleft <= Aright) {
                if (total % 2 == 0)
                    return ((double)Math.Max(Aleft, Bleft) + Math.Min(Aright, Bright)) / 2;
                else
                    return Math.Min(Aright, Bright);
            } else if (Aleft > Bright) {
                r = i - 1;
            } else {
                l = i + 1;
            }
        }
        return 0;
    }
}
