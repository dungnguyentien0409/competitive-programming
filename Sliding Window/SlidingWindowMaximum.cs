// Problem: https://leetcode.com/problems/sliding-window-maximum/submissions/
// Author: Dung Nguyen Tien (Chris)

public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        var window = new List<int>();
        var result = new List<int>();
        
        for (var i = 0; i < nums.Length; i++) {
            while (window.Count > 0 && window[0] < i - k + 1) 
                window.RemoveAt(0);
            while (window.Count > 0 && nums[i] > nums[window[window.Count - 1]]) 
                window.RemoveAt(window.Count - 1);
            
            window.Add(i);
            if (i >= k - 1) result.Add(nums[window[0]]);
        }
        
        return result.ToArray();
    }
}