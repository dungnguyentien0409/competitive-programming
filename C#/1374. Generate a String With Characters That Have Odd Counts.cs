/*
 * Link: https://leetcode.com/problems/generate-a-string-with-characters-that-have-odd-counts/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public string GenerateTheString(int n) {
        if (n % 2 == 0) {
            return Generate('a', n - 1) + Generate('b', 1);
        }
        
        return Generate('a', n);
    }
    
    public string Generate(char c, int n) {
        var str = new char[n];
        Array.Fill(str, c);
        
        return new string(str);
    }
}