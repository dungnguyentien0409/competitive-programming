/*
 * Link: https://leetcode.com/problems/maximize-distance-to-closest-person/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int MaxDistToClosest(int[] seats) {
        var start = -1;
        var len = 0;
        
        int i;
        for (i = 0; i < seats.Length; i++) {
            if (seats[i] == 1) {
                len = start < 0 ? i : Math.Max(len, (i - start) / 2);
                start = i;
            }
        }
        
        len = Math.Max(len, i - start - 1);
        
        return len;
    }
}