public class Solution {
	public  List<List<string>> GroupAnagrams(string[] strs)
	{
		Dictionary<string, List<string>> keyValuePairs = new Dictionary<string, List<string>>();
		foreach (string s in strs)
		{
			int[] count = new int[26];
			foreach (char c in s)
			{
				count[c - 'a']++;
			}
			string key = string.Join(",", count);
			if (!keyValuePairs.ContainsKey(key)) keyValuePairs[key] = new List<string>();

			keyValuePairs[key].Add(s);
		}

		return keyValuePairs.Values.ToList();
	}
}
