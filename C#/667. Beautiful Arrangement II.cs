/*
 * Link: https://leetcode.com/problems/beautiful-arrangement-ii/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int[] ConstructArray(int n, int k) {
        var res = new List<int>();
        
        int min = 1, max = k + 1;
        while(min <= max) {
            res.Add(min++);
            if (min < max) {
                res.Add(max--);
            }
        }
        
        for (var i = k + 2; i <= n; i++) res.Add(i);
        
        return res.ToArray();
    }
}