public class Solution {
    public int CharacterReplacement(string s, int k) {
        // s = "AABCCBBACCCAB", k = 2
        // replacements needed = windowSize - count(target character)
        HashSet<char> charSet = new HashSet<char>(s);
        int res = 0;
        foreach (char c in charSet) {
            int l = 0;
            int count = 0;
            for (int r = 0; r < s.Length; r++) {
                if (s[r] == c) {
                    count += 1;
                }
                while ((r - l + 1) - count > k) {
                    if (s[l] == c) {
                        count -= 1;
                    }
                    l++;
                }
                res = Math.Max(res, r - l + 1);
            }
        }
        return res;
    }
}
