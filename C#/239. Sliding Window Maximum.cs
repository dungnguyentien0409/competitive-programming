/*
 * Link: https://leetcode.com/problems/sliding-window-maximum/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        var queue = new List<int>();
        var res = new List<int>();
        
        for (var i = 0; i < nums.Length; i++) {
            while(queue.Count > 0 && queue[0] < i - k + 1) {
                queue.RemoveAt(0);
            }
            
            while(queue.Count > 0 && nums[queue[queue.Count - 1]] < nums[i])
                queue.RemoveAt(queue.Count - 1);
            
            queue.Add(i);
            if (i >= k - 1) {
                res.Add(nums[queue[0]]);
            }
        }
        
        return res.ToArray();
    }
}