public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        string sortS1 = new string(s1.OrderBy(c => c).ToArray());
        int s1Length = s1.Length;
        int s2Length = s2.Length;
        if (s1Length > s2Length)
            return false;

        bool res = false;
        for (int i = 0; i <= s2.Length; i++) {
            if (i + s1Length > s2Length)
                return false;

            string subString = s2.Substring(i, s1Length);
            string sortSubString = new String(subString.OrderBy(c => c).ToArray());
            if (sortS1 == sortSubString)
                return true;
        }

        return res;
    }
}
