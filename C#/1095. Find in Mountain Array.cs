/**
 * Link: https://leetcode.com/problems/find-in-mountain-array/
 * Author: Dung Nguyen Tien (Chris)
 * // This is MountainArray's API interface.
 * // You should not implement it, or speculate about its implementation
 * class MountainArray {
 *     public int Get(int index) {}
 *     public int Length() {}
 * }
 */
 
class Solution {
    public int FindInMountainArray(int target, MountainArray mountainArr) {
        var left = 0;
        var right = mountainArr.Length() - 1;
        var peak = FindPeak(mountainArr, left, right);
        
        var findIncrease = FindIncreaseArray(target, mountainArr, left, peak);
        var findDecrease = FindDecreaseArray(target, mountainArr, peak, right);
        
        return findIncrease != -1 ? findIncrease : findDecrease;
    }
    
    public int FindPeak(MountainArray mountainArr, int left, int right) {
        while (left < right) {
            var mid = (left + right) / 2;
            
            if (mountainArr.Get(mid) < mountainArr.Get(mid + 1)) {
                left = mid + 1;
            }
            else {
                right = mid;
            }
        }
        
        return left;
    }
    
    public int FindIncreaseArray(int target, MountainArray mountainArr, int left, int right) {
        while(left < right) {
            var mid = (left + right) / 2;
            var val = mountainArr.Get(mid);
            
            if (val == target) {
                return mid;
            }
            else if (val < target) {
                left = mid + 1;
            }
            else {
                right = mid;
            }
        }
        
        if (mountainArr.Get(left) == target) return left;
        return -1;
    }
    
    public int FindDecreaseArray(int target, MountainArray mountainArr, int left, int right) {
        while(left < right) {
            var mid = (left + right) / 2;
            var val = mountainArr.Get(mid);
            
            if (val == target) {
                return mid;
            }
            else if (val > target) {
                left = mid + 1;
            }
            else {
                right = mid;
            }
        }
        
        if (mountainArr.Get(left) == target) return left;
        return -1;
    }
}