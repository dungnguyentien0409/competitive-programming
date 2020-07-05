/*
 * Link: https://leetcode.com/problems/last-moment-before-all-ants-fall-out-of-a-plank/submissions/
 * Idea: lee215
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int GetLastMoment(int n, int[] left, int[] right) {
        var res = 0;
        
        foreach(var l in left) res = Math.Max(res, l);
        foreach(var r in right) res = Math.Max(res, n - r);
        
        return res;
    }
}