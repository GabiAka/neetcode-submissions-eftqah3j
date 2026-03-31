public class Solution {

    public string Encode(IList<string> strs) {
    			if (strs.Count == 0) return "";
			string res = string.Empty;
			foreach (var str in strs)
			{
				res += str.Length + "#" + str;
			}
			return res;    
    }

    public List<string> Decode(string s) {
	List<string> res = new List<string>();
	int i = 0;
	while (i < s.Length)
	{
		int j = i;
		while (s[j] != '#')
		{
			j++;
		}

		int length = int.Parse(s.Substring(i, j - i));
		j += 1;

		string split = s.Substring(j, length);
		res.Add(split);

		i = j + length;



	}

	return res;
   }
}
