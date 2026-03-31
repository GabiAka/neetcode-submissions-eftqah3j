public class Solution {
    public bool IsValidSudoku(char[][] board) {
Dictionary<int, HashSet<char>> rows = new Dictionary<int, HashSet<char>>();
Dictionary<int, HashSet<char>> cols = new Dictionary<int, HashSet<char>>();
Dictionary<(int, int), HashSet<char>> squares = new Dictionary<(int, int), HashSet<char>>();

for (int i = 0; i < 9; i++)
{
			rows.Add(i, new HashSet<char>());
			cols.Add(i, new HashSet<char>());

			for (int j = 0; j < 9; j++)
			{
				var key = (i / 3, j / 3);
				if (!squares.ContainsKey(key))
					squares.Add(key, new HashSet<char>());
			}
}

for (int r = 0; r < 9; r++)
{
			for (int c = 0; c < 9; c++)
			{
				char val = board[r][c];
				if (val == '.') continue;

				if (rows[r].Contains(val) ||
					cols[c].Contains(val) ||
					squares[(r / 3, c / 3)].Contains(val))
					return false;

				rows[r].Add(val);
				cols[c].Add(val);
				squares[(r / 3, c / 3)].Add(val);
			}
}
return true;        
    }
}
