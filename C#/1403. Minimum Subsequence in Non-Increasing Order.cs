/*
 * Link: https://leetcode.com/problems/minimum-subsequence-in-non-increasing-order/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public IList<int> MinSubsequence(int[] nums) {
        var sum = GetSum(nums);
        Array.Sort(nums, delegate(int a, int b) {
            return b - a;
        });
        
        var result = new List<int>();
        
        var s = 0;
        foreach(var n in nums) {
            s += n;
            result.Add(n);
            
            if (s > sum - s) break;
        }
        
        return result;
    }
    
    public int GetSum(int[] nums) {
        var sum = 0;
        
        foreach(var n in nums) {
            sum += n;
        }
        
        return sum;
    }
}