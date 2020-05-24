/*
 * Link: https://leetcode.com/problems/reverse-bits/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public uint reverseBits(uint n) {
        uint num = 0;
        
        for(var i = 0; i < 32; i++) {
            num *= 2;
            num += (n % 2);
            n /= 2;
        }
        
        return num;
    }
}