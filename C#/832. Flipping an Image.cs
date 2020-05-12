/*
 * Link: https://leetcode.com/problems/flipping-an-image/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int[][] FlipAndInvertImage(int[][] A) {
        int rows = A.Length, cols = A[0].Length;
        
        for (var i = 0; i < rows; i++) {
            var arr = A[i];
            int left = 0, right = cols - 1;
            
            while(left < right) {
                if (arr[left] == arr[right]) {
                    arr[left] = 1 - arr[left];
                    arr[right] = 1 - arr[right];
                }
                
                left++;
                right--;
            }
            
            if (left == right) {
                arr[left] = 1 - arr[left];
            }
        }
        
        return A;
    }
}