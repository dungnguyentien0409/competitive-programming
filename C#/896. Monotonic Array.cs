/*
 * Link: https://leetcode.com/problems/monotonic-array/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public bool IsMonotonic(int[] A) {
        bool increase = true, decrease = true;
        
        for (var i = 1; i < A.Length; i++) {
            increase &= A[i - 1] <= A[i];
            decrease &= A[i - 1] >= A[i];
        }
        
        return increase || decrease;
    }
}