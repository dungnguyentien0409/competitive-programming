/*
 * Link: https://leetcode.com/problems/split-array-largest-sum/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int SplitArray(int[] nums, int m) {
        long min = GetMinValue(nums);
        long max = GetMaxValue(nums);
        
        while(min < max) {
            // handle for big number
            var mid = min + (max - min) / 2;
            
            Console.WriteLine(min + " " + max + " " + mid);
            if (CheckResult(nums, m, mid)) {
                max = mid;
            }
            else {
                min = mid + 1;
            }
        }
        
        return (int)max;
    }
    
    public bool CheckResult(int[] nums, long m, long mid) {
        // mid if the max subarray
        // to minimize that max, so another subarray should come to that value
        
        long sum = 0, count = 0;
        
        foreach(var n in nums) {
            sum += n;
            
            if (sum > mid) {
                sum = n;
                count++;

                if (count > m - 1) return false;
            }
        }
        
        // cuz if count < mid we wil return true also to decrease the mid
        // decrease mid can get more count to get count = 0; also come to final result
        return true;
    }
    
    public long GetMinValue(int[] nums) {
        long min = nums[0];
        
        foreach(var n in nums) min = Math.Max(min, n);
        
        return min;
    }
    
    public long GetMaxValue(int[] nums) {
        long max = 0;
        
        foreach(var n in nums) max += n;
        
        return max;
    }
}