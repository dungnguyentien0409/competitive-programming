/*
 * Link: https://leetcode.com/problems/contiguous-array/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int FindMaxLength(int[] nums) {
        var map = new Dictionary<int, int>();
        var sum = 0;
        var res = 0;
        
        map.Add(0, -1);
        for(var i = 0; i < nums.Length; i++) {
            if (nums[i] == 1) sum++;
            else sum--;
            
            if (!map.ContainsKey(sum)) {
                map.Add(sum, i);
            }
            res = Math.Max(res, i - map[sum]);
        }
        
        return res;
    }
}