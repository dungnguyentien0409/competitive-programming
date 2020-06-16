/*
 * Link: https://leetcode.com/problems/shifting-letters/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public string ShiftingLetters(string S, int[] shifts) {
        var shift = 0;
        var sb = new StringBuilder();
        
        for(var i = shifts.Length - 1; i >= 0; i--) {
            shift = (shift + shifts[i]) % 26;
            sb.Insert(0, ShiftChar(S[i], shift));    
        }
        
        Console.WriteLine(ShiftChar('d', 30));
        return sb.ToString();
    }
    
    public char ShiftChar(char c, int shift) {
        c = (char)((c - 'a' + shift) % 26 + 'a');
        
        return c;
    }
}