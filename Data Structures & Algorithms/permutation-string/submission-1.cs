public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        // s1="ab"
        // s2="eidbaooo"
        if (s1.Length > s2.Length)
            return false;
        int[] s1Count = new int[26];
        int[] s2Count = new int[26];
        for (int i = 0; i < s1.Length; i++) {
            s1Count[s1[i] - 'a']++;
            s2Count[s2[i] - 'a']++;
        }

        int matches = 0;
        for (int i = 0; i < 26; i++) {
            if (s1Count[i] == s2Count[i])
                matches += 1;
        }

        int l = 0;
        for (int r = s1.Length; r < s2.Length; r++) {
            if (matches == 26)
                return true;

            // index vi tri right
            int index = s2[r] - 'a';
            s2Count[index]++;
            if (s1Count[index] == s2Count[index]) {
                matches++;
            } else if (s1Count[index] + 1 == s2Count[index]) {
                matches--;
            }

            // index vi tri left
            index = s2[l] - 'a';
            s2Count[index]--;
            if (s1Count[index] == s2Count[index]) {
                matches++;
            } else if (s1Count[index] - 1 == s2Count[index]) {
                matches--;
            }
            l++;
        }

        return matches == 26;
    }
}
