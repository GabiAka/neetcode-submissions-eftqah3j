public class Solution {
    public bool IsValidSudoku(char[][] board) {
			HashSet<char>[] rows = new HashSet<char>[9];
			HashSet<char>[] columns = new HashSet<char>[9];
			HashSet<char>[] boxes = new HashSet<char>[9];

			for (int i = 0; i < 9; i++)
			{
				rows[i] = new HashSet<char>();
				columns[i] = new HashSet<char>();
				boxes[i] = new HashSet<char>();
			}

			for (int r = 0; r < 9; r++)
			{
				for (int c = 0; c < 9; c++)
				{
					if (board[r][c] == '.') continue;

					int boxIndex = (r / 3) * 3 + c / 3;
					char charCurrent = board[r][c];

					if (rows[r].Contains(charCurrent) || columns[c].Contains(charCurrent) || boxes[boxIndex].Contains(charCurrent)) return false;

					rows[r].Add(charCurrent);
					columns[c].Add(charCurrent);
					boxes[boxIndex].Add(charCurrent);
				}
			}
			return true;
    }
}
