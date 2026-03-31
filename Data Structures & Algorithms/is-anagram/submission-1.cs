public class Solution {
    public bool IsAnagram(string s, string t) {
	if (s.Length != t.Length) return false;

	Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();

	foreach (char c in s)
	{
		if (keyValuePairs.ContainsKey(c)) keyValuePairs[c]++;
		else keyValuePairs.Add(c, 1);
	}

	foreach (char c in t)
	{
		if (!keyValuePairs.ContainsKey(c)) return false;

		int val = keyValuePairs[c];

		if (val == 0) return false;

		keyValuePairs[c] -= 1;
	}

	return true;
    }
}
