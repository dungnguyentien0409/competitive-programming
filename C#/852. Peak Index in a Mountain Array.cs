/*
 * Link: https://leetcode.com/problems/peak-index-in-a-mountain-array/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int PeakIndexInMountainArray(int[] A) {
        var left = 0;
        var right = A.Length - 1;
        
        while(left < right) {
            var mid = (left + right) / 2;
            
            if (A[mid] < A[mid + 1]) left = mid + 1;
            else right = mid;
        }
        
        return left;
    }
}