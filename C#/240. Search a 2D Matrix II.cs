/*
 * Link: https://leetcode.com/problems/search-a-2d-matrix-ii/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public bool SearchMatrix(int[,] matrix, int target) {
        // start from the top right
        // if target < current => go left
        // if target > current => go down
        // if come to bottom left doesnt find => false
        int currentX = 0, currentY = matrix.GetLength(1) - 1;
        int endX = matrix.GetLength(0) - 1, endY = 0;
        
        while(currentX <= endX && currentY >= endY) {
            var cur = matrix[currentX, currentY];
            if (cur == target) return true;
            else if (cur > target) currentY--;
            else currentX++;
        }
        
        return false;
    }
}