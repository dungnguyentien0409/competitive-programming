/*
 * Link: https://leetcode.com/problems/squares-of-a-sorted-array/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int[] SortedSquares(int[] A) {
        int left = 0, right = A.Length - 1;
        var res = new int[A.Length];
        
        for (var i = A.Length - 1; i >= 0; i--) {
            if (Math.Abs(A[left]) > Math.Abs(A[right])) {
                res[i] = A[left] * A[left];
                left++;
            }
            else {
                res[i] = A[right] * A[right];
                right--;
            }
        }
        
        return res;
    }
}