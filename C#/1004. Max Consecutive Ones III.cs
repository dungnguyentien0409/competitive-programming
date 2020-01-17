/*
 * Link: https://leetcode.com/problems/max-consecutive-ones-iii/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int LongestOnes(int[] A, int K) {
        int begin = 0, end = 0;
        int count = 0, maxLen = 0;
        
        while(end < A.Length) {
            if (A[end++] == 0) {
                count++;
            }
            
            while(count > K) {
                if (A[begin++] == 0) count--;
            }
            
            maxLen = Math.Max(maxLen, end - begin);
        }
        
        return maxLen;
    }
}