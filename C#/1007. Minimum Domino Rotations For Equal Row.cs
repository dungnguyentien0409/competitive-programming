/*
 * Link: https://leetcode.com/problems/minimum-domino-rotations-for-equal-row/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int MinDominoRotations(int[] A, int[] B) {
        int[] countA = new int[7], countB = new int[7], same = new int[7];
        
        for (var i = 0; i < A.Length; i++) {
            countA[A[i]]++;
            countB[B[i]]++;
            
            if (A[i] == B[i]) same[A[i]]++;
        }
        
        var res = Int32.MaxValue;
        for (var i = 1; i < 7; i++) {
            if (countA[i] + countB[i] - same[i] == A.Length) {
                res = Math.Min(res, A.Length - Math.Max(countA[i], countB[i]));
            }
        }
        
        return res < Int32.MaxValue ? res : -1;
    }
}