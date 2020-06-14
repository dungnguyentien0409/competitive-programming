/*
 * Link: https://leetcode.com/problems/kth-largest-element-in-an-array/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        int left = 0, right = nums.Length - 1;
        int pivot = -1;
        k = nums.Length - k;
            
        while(left < right) {
            pivot = Partition(nums, left, right);
            
            if (pivot == k) {
                return nums[k];
            }
            else if (pivot < k) {
                left = pivot + 1;
            }
            else {
                right = pivot - 1;
            }
        }
        
        return nums[k];
    }
    
    public int Partition(int[] nums, int left, int right) {
        
        int pivot = nums[right];
        int i = left - 1;
        
        for (var j = left; j < right; j++) {
            if (nums[j] < pivot) {
                i++;
                Swap(nums, i, j);
            }
        }
        
        // swap pivot to its correct position
        i++;
        Swap(nums, i, right);
        
        return i;
    }
    
    public void Swap(int[] nums, int x, int y) {
        if (x == y) return;
        
        var tmp = nums[x];
        nums[x] = nums[y];
        nums[y] = tmp;
    }
}