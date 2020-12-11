/*
 * Link: https://leetcode.com/problems/valid-mountain-array/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public bool ValidMountainArray(int[] A) {
        if (A.Length < 3) return false;
        
        var index = FindMaxIndex(A);
        
        if (index == 0 || index == A.Length - 1
           || A[index] == A[index - 1] || A[index] == A[index + 1]) return false;
        
        for (var i = 0; i < index; i++) {
            if (A[i] >= A[i + 1]) return false;
        }
        
        for (var i = index; i < A.Length - 1; i++) {
            if (A[i] <= A[i + 1]) return false;
        }
        
        return true;
    }
    
    public int FindMaxIndex(int[] A) {
        var index = 0;
        
        for(var i = 0; i < A.Length; i++) {
            if (A[i] > A[index]) {
                index = i;
            }
        }
        
        return index;
    }
}