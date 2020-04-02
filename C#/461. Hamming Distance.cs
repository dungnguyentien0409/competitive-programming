/*
 * Link: https://leetcode.com/problems/hamming-distance/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int HammingDistance(int x, int y) {
        var z = x ^ y;
        var count = 0;
        
        while(z > 0) {
            z = z & (z - 1);
            count++;
        }
        
        return count;
    }
}