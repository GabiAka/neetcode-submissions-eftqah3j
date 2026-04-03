public class Solution {
    public bool IsValid(string s) {
        if(s.Length == 1) return false;
 			string closeBracket = "}])";
			string openBracket = "{[(";
			Stack<char> chars = new Stack<char>();

			for (int i = 0; i < s.Length; i++)
			{
				char c = s[i];
				if (openBracket.Contains(c))
				{
					chars.Push(c);
				}
				else
				{
                    if(chars.Count == 0) return false;
					var popItem = chars.Pop();
					int popIndex = openBracket.IndexOf(popItem);
					int cIndex = closeBracket.IndexOf(c);
					if (popIndex != cIndex) return false;
				}
			}

			if (chars.Count == 0) return true;
			return false;       
    }
}
