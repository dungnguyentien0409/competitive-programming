/*
 * Link: https://leetcode.com/problems/minimum-moves-to-equal-array-elements/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int MinMoves(int[] nums) {
        if (nums.Length <= 1) return 0;
        
        int min = Int32.MaxValue;
        foreach(var n in nums) min = Math.Min(min, n);
        
        int res = 0;
        foreach(var n in nums) res += (n - min);
        
        return res;
    }
}