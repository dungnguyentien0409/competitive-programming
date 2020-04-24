/*
 * Link: https://leetcode.com/problems/range-sum-query-immutable/
 * Author: Dung Nguyen Tien (Chris)
*/

public class NumArray {
    int[] res;
    
    public NumArray(int[] nums) {
        res = new int[nums.Length];
        var sum = 0;
        
        for (var i = 0; i < nums.Length; i++) {
            sum += nums[i];
            res[i] = sum;
        }
    }
    
    public int SumRange(int i, int j) {
        return i - 1 >= 0 ? res[j] - res[i - 1] : res[j];
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(i,j);
 */