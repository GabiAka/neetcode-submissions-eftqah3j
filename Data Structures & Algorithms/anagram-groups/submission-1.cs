public class Solution {
  	public List<List<string>> GroupAnagrams(string[] strs)
	{
	List<string> lstStr = new List<string>(strs);
	List<List<string>> strings = new List<List<string>>();
	bool isContinue = true;
	while (isContinue)
	{
		if (lstStr.Count == 0)
		{
			isContinue = false;
			break;
		}

		//loop kiểm tra từng item
		var first = lstStr[0];
		lstStr.Remove(first);
		List<string> strings1 = new List<string>();
		strings1.Add(first);
		foreach (string item in lstStr)
		{
			bool isAnagram = IsAnagram(item, first);
			if (isAnagram)
			{
				strings1.Add(item);
			}
		}

		foreach (var item in strings1)
		{
			lstStr.Remove(item);
		}
		strings.Add(strings1);
	}
	return strings;
	}

	public bool IsAnagram(string s, string t)
	{
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
