/*
 * Link: https://leetcode.com/problems/number-of-substrings-with-only-1s/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int NumSub(string s) {
        int res = 0, current = 0;
        
        foreach(var c in s) {
            if (c == '1') current++;
            else current = 0;
            
            res = (res + current) % 1000000007;
        }
        
        return res;
    }
}