/*
 * Problem: https://leetcode.com/problems/pascals-triangle-ii/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public IList<int> GetRow(int rowIndex) {
        var array = new int[rowIndex + 1];
        array[0] = 1;
        
        if (rowIndex == 0) return array;
        
        for (var r = 1; r <= rowIndex; r++) {
            for (var c = r; c > 0; c--) {
                array[c] += array[c - 1];
            }
        }
        
        return new List<int>(array);
    }
}