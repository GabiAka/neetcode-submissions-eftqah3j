public class Solution {
    public bool IsAnagram(string s, string t) {
		if (s.Length != t.Length) return false;
Dictionary<char, int> hashtableS = new Dictionary<char, int>();
foreach (char c in s)
{
			if (hashtableS.ContainsKey(c))
			{
				hashtableS[c] = (int)hashtableS[c] + 1;
			}
			else
			{
				hashtableS.Add(c, 1);
			}
}
Dictionary<char, int> hashtableT = new Dictionary<char, int>();
foreach (char c in t)
{
			if (hashtableT.ContainsKey(c))
			{
				hashtableT[c] = (int)hashtableT[c] + 1;
			}
			else
			{
				hashtableT.Add(c, 1);
			}
}

foreach (var kvp in hashtableS)
{
			if (!hashtableT.ContainsKey(kvp.Key) || hashtableT[kvp.Key] != kvp.Value)
			{
				return false;
			}
}
return true;
    }
}
