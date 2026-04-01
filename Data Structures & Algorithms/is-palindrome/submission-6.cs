public class Solution {
public  bool IsPalindrome(string s)
{
	string newStr = "";
	foreach (var item in s)
	{
		if (AlphaNum(item)) newStr += item;
	}

	int start = 0, end = newStr.Length - 1;
	while (start < end)
	{
		if (newStr[start].ToString().ToLower() != newStr[end].ToString().ToLower()) return false;
		start += 1;
		end -= 1;
	}

	return true;
}

public  bool AlphaNum(char c)
{
	return (c >= 'A' && c <= 'Z' ||
			  c >= 'a' && c <= 'z' ||
			  c >= '0' && c <= '9');
}
}
