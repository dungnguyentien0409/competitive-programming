/*
 * Link: https://leetcode.com/problems/find-all-duplicates-in-an-array/
 * Idea: YuxinCao
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public IList<int> FindDuplicates(int[] nums) {
        var res = new List<int>();
        
        for (var i = 0; i < nums.Length; i++) {
            var index = Math.Abs(nums[i]) - 1;
            
            if (nums[index] < 0) {
                res.Add(index + 1);
            }
            
            nums[index] = -nums[index];
        }
        
        return res;
    }
}