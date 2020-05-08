/*
 * Link: https://leetcode.com/problems/valid-parenthesis-string/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * Idea: sansi
*/

public class Solution {
    public bool CheckValidString(string s) {
        int low = 0, high = 0;
        
        foreach(var c in s) {
            if (c == '(') {
                low++; high++;
            }
            else if (c == ')') {
                low--; high--;
            }
            else { // c == '*'
                low--; high++;
            }
            
            if (low < 0) low = 0;
            if (high < 0) return false;
        }
        
        return low == 0;
    }
}