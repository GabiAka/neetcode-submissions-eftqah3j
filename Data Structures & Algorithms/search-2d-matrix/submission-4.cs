public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int ROWS = matrix.Length;
        int COLS = matrix[0].Length;

        int top = 0, bot = ROWS - 1;
        int row = 0;
        while (top <= bot) {
            row = (bot + top) / 2;

            if (target > matrix[row][COLS - 1]) {
                top = row + 1;
            } else if (target < matrix[row][0]) {
                bot = row - 1;
            } else {
                break;
            }
        }

       if (!(top <= bot)) {
            return false;
        }


        int l = 0, r = COLS - 1;
        while (l <= r) {
            int mid = (l + r) / 2;
            if(matrix[row][mid] == target) return true;

            if(matrix[row][mid] > target){
                r = mid - 1;

            }else{
                l = mid + 1;
            }
        }
        return false;
    }
}
