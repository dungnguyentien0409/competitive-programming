/*
 * Link: https://leetcode.com/problems/number-of-subsequences-that-satisfy-the-given-sum-condition/
 * Idea: lee215
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int NumSubseq(int[] nums, int target) {
        Array.Sort(nums, delegate(int a, int b) {
            return a - b;
        });
        
        ulong res = 0;
        ulong MAX = (ulong)Math.Pow(10, 9) + 7;
        int left = 0, right = nums.Length - 1;
        while(left <= right) {
            if (nums[left] + nums[right] > target) {
                right--;
            }
            else {
                res = (res + (ulong)BigInteger.ModPow(2, right - left, MAX)) % MAX;
                left++;
            }
        }
        
        return (int)res;
    }
}