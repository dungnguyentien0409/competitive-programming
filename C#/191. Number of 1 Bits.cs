/*
 * Link: https://leetcode.com/problems/number-of-1-bits/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int HammingWeight(uint n) {
        int count = 0;
        
        while(n > 0) {
            count += (int)(n & 1);
            n = n >> 1;
        }
        
        return count;
    }
}