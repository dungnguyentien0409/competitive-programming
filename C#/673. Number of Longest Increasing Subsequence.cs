/*
 * Link: https://leetcode.com/problems/number-of-longest-increasing-subsequence/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int FindNumberOfLIS(int[] nums) {
        int n = nums.Length, count = 0, maxLen = 0;
        int[] len = new int[n], count_len = new int[n];
        
        for(var i = 0; i < n; i++) {
            len[i] = 1;
            count_len[i] = 1;
            
            for (var j = 0; j < i; j++) {
                if (nums[i] > nums[j]) {
                    if (len[i] == len[j] + 1) {
                        count_len[i] += count_len[j];
                    }
                    else if (len[i] < len[j] + 1) {
                        len[i] = len[j] + 1;
                        count_len[i] = count_len[j];
                    }
                }
            }
            
            if (len[i] > maxLen) {
                maxLen = len[i];
                count = count_len[i];
            }
            else if (len[i] == maxLen) {
                count += count_len[i];
            }
        }
        
        return count;
    }
}