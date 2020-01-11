/*
 * Link: https://leetcode.com/problems/two-sum-less-than-k/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int TwoSumLessThanK(int[] A, int K) {
        Array.Sort(A, delegate(int a, int b) {
            return a - b;
        });
            
        int closest = Int32.MinValue;
        int left = 0, right = A.Length - 1;
        int sum;
        
        while (left < right) {
            sum = A[left] + A[right];
            if (sum >= K) right--;
            else {
                closest = Math.Max(closest, sum);
                left++;
            }
        }
        
        return closest == Int32.MinValue ? -1 : closest;
    }
}