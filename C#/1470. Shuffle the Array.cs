/*
 * Link: https://leetcode.com/problems/shuffle-the-array/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        var res = new int[nums.Length];
        
        int i = 0, j = n;
        int index = 0;
        while(i < n) {
            res[index++] = nums[i++];
            res[index++] = nums[j++];
        }
        
        return res;
    }
}