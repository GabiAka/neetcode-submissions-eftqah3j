public class Solution {
    public bool IsValid(string s) {
        Stack<char> stacks = new Stack<char>();
foreach (char c in s)
{
			if (c == '(' || c == '[' || c == '{')
			{
				stacks.Push(c);
			}
			else if (c == ')' || c == ']' || c == '}')
			{
				if (stacks.Count == 0) return false;
				char pop = stacks.Pop();
				if ((c == ')' && pop != '(') ||
					(c == ']' && pop != '[') ||
						(c == '}' && pop != '{')
					)
				{
					return false;
				}
			}

}
return stacks.Count == 0;
    }
}
