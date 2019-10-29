// Problem: https://leetcode.com/problems/132-pattern/
// Author: Dung Nguyen Tien (Chris)

public class Solution {
    public bool Find132pattern(int[] nums) {
        int i = 1, s = 0;
        var list = new List<int[]>();
        
        while(i < nums.Length) {
            if (nums[i - 1] > nums[i]) {
                list.Add(new int[] {nums[s], nums[i - 1]});
                s = i;
            }
            
            foreach(int[] block in list) {
                if (nums[i] < block[1] && nums[i] > block[0]) return true;
            }
            i++;
        }
        
        return false;
    }
}