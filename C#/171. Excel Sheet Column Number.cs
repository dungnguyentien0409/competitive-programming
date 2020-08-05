/*
 * Link: https://leetcode.com/problems/excel-sheet-column-number/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int TitleToNumber(string s) {
        int carry = 0;
        int res = 0;
        
        for (var i = s.Length - 1; i >= 0; i--) {
            res = res + (int)Math.Pow(26, carry) * (s[i] - 'A' + 1);
            
            carry++;
        }
        
        return res;
    }
}