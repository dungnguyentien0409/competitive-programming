/*
 * Link: https://leetcode.com/problems/sort-array-by-parity-ii/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int[] SortArrayByParityII(int[] A) {
        int even = -2;
        
        for(var i = 0; i < A.Length; i++) {
            while (A[i] % 2 == 0 && i % 2 != 0) {
                even += 2;
                Swap(A, i, even);
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