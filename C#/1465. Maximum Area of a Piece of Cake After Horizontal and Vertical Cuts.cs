/*
 * Link: https://leetcode.com/problems/maximum-area-of-a-piece-of-cake-after-horizontal-and-vertical-cuts/
 * Author: Dung Nguyen Tien(Chris)
*/

public class Solution {
    public int MaxArea(int h, int w, int[] horizontalCuts, int[] verticalCuts) {
        var height = GetMax(horizontalCuts, h);
        var width = GetMax(verticalCuts, w);
        double MAX = Math.Pow(10, 9) + 7;
        
        return (int)((height % MAX) * (width % MAX) % MAX);
    }
    
    public int GetMax(int[] cuts, int max) {
        var list = new List<int>(cuts);
        list.Add(0);
        list.Add(max);
        list.Sort();
        
        int res = 0;
        for (var i = 1; i < list.Count; i++) {
            res = Math.Max(res, list[i] - list[i - 1]);
        }
        
        return res;
    }
}