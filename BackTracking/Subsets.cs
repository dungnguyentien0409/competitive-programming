// Problem: https://leetcode.com/problems/subsets/
// Author: Dung Nguyen Tien (Chris)

public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        var res = new List<IList<int>>();
        
        backtrack(nums, res, new List<int>(), 0);
        
        return res;
    }
    
    void backtrack(int[] nums, List<IList<int>>res, List<int> tmp, int start) {
        res.Add(new List<int>(tmp));
        
        for (var i = start; i < nums.Length; i++) {
            tmp.Add(nums[i]);
            backtrack(nums, res, tmp, i + 1);
            tmp.RemoveAt(tmp.Count - 1);
        }
    }
}

