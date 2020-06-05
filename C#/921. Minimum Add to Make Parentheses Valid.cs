/*
 * Link: https://leetcode.com/problems/minimum-add-to-make-parentheses-valid/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int MinAddToMakeValid(string S) {
        var st = 0;
        var count = 0;
        
        foreach(var c in S) {
            if (c == '(') {
                st++;
            }
            else {
                st--;
                
                if (st <= 0) {
                    count += Math.Abs(st);
                    st = 0;
                }
            }
        }
        
        count += Math.Abs(st);
        
        return count;
    }
}