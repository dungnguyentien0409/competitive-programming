/*
 * Link: https://leetcode.com/problems/sort-array-by-parity/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int[] SortArrayByParity(int[] A) {
        var j = -1;
        
        for(var i = 0; i < A.Length; i++) {
            if (A[i] % 2 == 0) {
                j++;
                Swap(A, i, j);
            }
        }
        
        return A;
    }
    
    public void Swap(int[] A, int x, int y) {
        if (x == y) return;
        
        var tmp = A[x];
        A[x] = A[y];
        A[y] = tmp;
    }
}