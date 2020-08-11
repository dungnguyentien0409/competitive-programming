/*
 * Link: https://leetcode.com/problems/summary-ranges/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        var res = new List<string>();
        int start = 0, end = 0;
        
        for (var i = 0; i < nums.Length; i++) {
            while(i < nums.Length - 1 && nums[i] + 1 == nums[i + 1]) {
                end++;
                i++;
            }
            
            if (start == end) {
                res.Add(nums[start] + "");
            }
            else {
                res.Add(nums[start] + "->" + nums[end]);
            }
            
            end++;
            start = end;
        }
        
        return res;
    }
}