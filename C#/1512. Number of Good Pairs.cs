/*
 * Link: https://leetcode.com/problems/number-of-good-pairs/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int NumIdenticalPairs(int[] nums) {
        var map = new Dictionary<int, int>();
        var count = 0;
        
        foreach(var n in nums) {
            if (!map.ContainsKey(n)) map.Add(n, 0);
            
            count += map[n];
            map[n]++;
        }
        
        return count;
    }
}