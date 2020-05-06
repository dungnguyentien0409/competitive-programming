/*
 * Link: https://leetcode.com/problems/longest-increasing-subsequence/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int LengthOfLIS(int[] nums) {
        var tails = new int[nums.Length];
        var size = 0;
        
        foreach(var n in nums) {
            var index = BinarySearch(tails, 0, size - 1, n);
            
            tails[index] = n;
            if (index == size) size++;
        }
        
        return size;
    }
    
    public int BinarySearch(int[] tails, int left, int right, int target) {
        if (left > right) return 0;
        
        while(left < right) {
            var mid = (left + right) / 2;
            
            if (tails[mid] < target) left = mid + 1;
            else right = mid;
        }
        
        if (tails[left] < target) return left + 1;
        return left;
    }
}