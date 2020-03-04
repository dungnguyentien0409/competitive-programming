/*
 * Link: https://leetcode.com/problems/pascals-triangle/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        if (numRows == 0) return new List<IList<int>>();
        
        var res = new List<IList<int>>();
        
        res.Add(new List<int>() {1});
        if (numRows == 1) return res;
        
        for (var r = 2; r <= numRows; r++) {
            var preRow = res[r - 2];
            
            var currentRow = new List<int>() {};
            
            for (var col = 0; col < r; col++) {
                int top = (col == r - 1) ? 0 : preRow[col];
                int topLeft = (col == 0) ? 0 : preRow[col - 1];
                
                currentRow.Add(top + topLeft);
            }
            
            res.Add(currentRow);
        }
        
        return res;
    }
}