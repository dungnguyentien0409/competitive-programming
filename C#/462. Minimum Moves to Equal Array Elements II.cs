/*
 * Link: https://leetcode.com/problems/minimum-moves-to-equal-array-elements-ii/
 * Author: Dung Nguyen Tien (Chris)
*/
public class Solution {
    public int MinMoves2(int[] nums) {
        Array.Sort(nums);
        int i = 0, j = nums.Length - 1;
        int res = 0;
        
        while(i < j) {
            if (nums[i] < nums[j]) {
                res += nums[j] - nums[i];
            }
            
            i++;
            j--;
        }
        
        return res;
    }
}