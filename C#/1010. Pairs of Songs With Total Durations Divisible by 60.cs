/*
 * Link: https://leetcode.com/problems/pairs-of-songs-with-total-durations-divisible-by-60/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int NumPairsDivisibleBy60(int[] time) {
        var map = new int[60];
        int count = 0;
        
        foreach(var t in time) {
            if (t % 60 == 0) {
                count += map[0];
            }
            else {
                count += map[60 - t % 60];
            }
            
            map[t % 60]++;
        }
        
        return count;
    }
}