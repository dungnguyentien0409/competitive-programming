/*
 * Link: https://leetcode.com/problems/1-bit-and-2-bit-characters/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public bool IsOneBitCharacter(int[] bits) {
        var i = 0;
        
        while(i < bits.Length - 1) {
            if (bits[i] == 0) i++;
            else if (bits[i] == 1) i += 2;
        }
        
        return i == bits.Length -1;
    }
}