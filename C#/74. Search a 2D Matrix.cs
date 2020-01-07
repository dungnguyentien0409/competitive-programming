/*
 * Link: https://leetcode.com/problems/search-a-2d-matrix/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        // start from bottom left
        // if current < target go up
        // if current > target go right
        if (matrix.Length == 0 || matrix[0].Length == 0) return false;
        
        int curX = matrix.Length - 1, curY = 0;
        int endX = 0, endY = matrix[0].Length - 1;
        
        while(curX >= endX && curY <= endY) {
            var val = matrix[curX][curY];
            
            Console.WriteLine(val);
            if (val == target) return true;
            else if (val > target) curX--;
            else curY++;
        }
        
        return false;
    }
}