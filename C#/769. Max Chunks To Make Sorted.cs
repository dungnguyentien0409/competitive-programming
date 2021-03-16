/*
 * Link: https://leetcode.com/problems/max-chunks-to-make-sorted/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int MaxChunksToSorted(int[] arr) {
        int count = 0, max = 0;
        
        for (var i = 0; i < arr.Length; i++) {
            max = Math.Max(max, arr[i]);
            
            if (max == i) {
                count++;
            }
        }
        
        return count;
    }
}