/*
 * Link: https://leetcode.com/problems/assign-cookies/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int FindContentChildren(int[] g, int[] s) {
        Array.Sort(g, delegate(int a, int b) { return a - b; });
        Array.Sort(s, delegate(int a, int b) { return a - b; });
        
        var child = 0;
        for (var i = 0; i < s.Length && child < g.Length; i++) {
            if (s[i] >= g[child]) {
                child++;
            }
        }
        
        return child;
    }
}