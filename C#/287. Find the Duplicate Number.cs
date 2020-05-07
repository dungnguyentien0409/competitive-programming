/*
 * Link: https://leetcode.com/problems/find-the-duplicate-number/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int FindDuplicate(int[] nums) {
        int low = 1, high = nums.Length - 1;
        
        while(low < high) {
            int mid = (low + high) / 2;
            int count = 0;
            
            foreach(var n in nums) {
                if (n <= mid) {
                    count++;
                }
            }
                
            if (count <= mid) low = mid + 1;
            else high = mid;
        }
        
        return low;
    }
}