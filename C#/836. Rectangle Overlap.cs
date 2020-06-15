/*
 * Link: https://leetcode.com/problems/rectangle-overlap/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public bool IsRectangleOverlap(int[] rec1, int[] rec2) {
        var xL = Math.Max(rec1[0], rec2[0]);
        var yL = Math.Max(rec1[1], rec2[1]);
        var xR = Math.Min(rec1[2], rec2[2]);
        var yR = Math.Min(rec1[3], rec2[3]);
        
        return xL < xR && yL < yR;
    }
}