/*
 * Link: https://leetcode.com/problems/count-of-smaller-numbers-after-self/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public IList<int> CountSmaller(int[] nums) {
        if (nums.Length == 0) return new int[0];
        if (nums.Length == 1) return new int[1] {0};
        
        var counts = new int[nums.Length];
        var sorted = new List<int>();
        
        counts[nums.Length - 1] = 0;
        sorted.Add(nums[nums.Length - 1]);
        for (var i = nums.Length - 2; i >= 0; i--) {
            var n = nums[i];
            var index = BinarySearch(sorted, n);
            
            sorted.Insert(index, n);
            counts[i] = index;
        }
        
        return counts;
    }
    
    public int BinarySearch(List<int> sorted, int target) {
        var left = 0;
        var right = sorted.Count - 1;
        
        while(left < right) {
            var mid = (left + right) / 2;
            
            if (sorted[mid] < target) left = mid + 1;
            else right = mid;
        }
        
        if (sorted[left] < target) return left + 1;
        return left;
    }
}