/*
 * Link: https://leetcode.com/problems/132-pattern/
 * Idea: Jade86
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public bool Find132pattern(int[] nums) {
        if (nums.Length < 3) return false;
        
        var st = new Stack<int>();
        var s3 = Int32.MinValue;
        
        for (var i = nums.Length - 1; i >= 0; i--) {
            if (nums[i] < s3) return true;
            else {
                while(st.Count > 0 && nums[i] > st.Peek()) {
                    s3 = st.Pop();
                }
                
                st.Push(nums[i]);
            }
        }
        
        return false;
    }
}