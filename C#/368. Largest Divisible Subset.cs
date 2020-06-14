/*
 * Link: https://leetcode.com/problems/largest-divisible-subset/
 * Idea: jiangbowei2010
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public IList<int> LargestDivisibleSubset(int[] nums) {
        int len = nums.Length;
        var count = new int[len];
        var pre = new int[len];
        Array.Sort(nums, delegate(int a, int b) { return a - b; });
        int maxLen = 0, index = -1;
        
        for (var i = 0; i < len; i++) {
            count[i] = 1;
            pre[i] = -1;
            
            for (var j = i - 1; j >= 0; j--) {
                if (nums[i] % nums[j] == 0 && 1 + count[j] > count[i]) {
                    count[i] = count[j] + 1;
                    pre[i] = j;
                }
            }
            
            if (count[i] > maxLen) {
                maxLen = count[i];
                index = i;
            }
        }
        
        var res = new List<int>();
        while(index > -1) {
            res.Add(nums[index]);
            index = pre[index];
        }
        
        return res;
    }
}