/*
 * Link: https://leetcode.com/problems/counting-bits/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * Idea: JackieDreamy
*/

public class Solution {
    public int[] CountBits(int num) {
        var res = new int[num + 1];
        var offset = 1;
        
        for (var i = 1; i <= num; i++) {
            if (offset * 2 == i) {
                offset *= 2;
            }
            
            res[i] = res[i - offset] + 1;
        }
        
        return res;
    }
}