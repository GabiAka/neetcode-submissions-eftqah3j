public class Solution {
    public bool IsPalindrome(string s) {
        bool res = true;
int left = 0, right = s.Length - 1;
List<char> specialCharacter = new List<char>() { ' ', '?', ',', '\'' };
string allowChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
if (left == right) return true;
while (left < right)
{
			while (!allowChars.Contains(s[left]) && left < right)
			{
				left++;
			}

			while (!allowChars.Contains(s[right]) && left < right)
			{
				right--;
			}

			if (s[left].ToString().ToLower() != s[right].ToString().ToLower())
			{
				return false;
			}
			else
			{
				left++;
				right--;
			}
}
return res;
    }
}
