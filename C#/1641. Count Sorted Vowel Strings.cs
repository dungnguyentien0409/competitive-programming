/*
 * Link: https://leetcode.com/problems/count-sorted-vowel-strings/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int CountVowelStrings(int n) {
        if (n == 0) return n;
        
        int a = 1, e = 1, i = 1, o = 1, u = 1;
        
        while(n > 1) {
            //add to first
            a = a + e + i + o + u;
            e = e + i + o + u;
            i = i + o + u;
            o = o + u;
            u = u;
            
            n--;
        }
        
        return a + e + i + o + u;
    }
}