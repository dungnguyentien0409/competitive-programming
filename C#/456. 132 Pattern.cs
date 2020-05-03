/*
 * Link: https://leetcode.com/problems/132-pattern/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public bool Find132pattern(int[] nums) {
        if (nums.Length < 3) return false;
        
        var st = new List<int[]>();
        var s = 0;
        
        for (var i = 1; i < nums.Length; i++) {
            if (nums[i - 1] > nums[i]) {
                st.Add(new int[] { nums[s], nums[i - 1] });
                s = i;
            }
            
            foreach(var d in st) {
                if (nums[i] > d[0] && nums[i] < d[1]) return true;
            }
        }
        
        return false;
    }
}