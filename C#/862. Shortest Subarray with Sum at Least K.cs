/*
 * Link: https://leetcode.com/problems/shortest-subarray-with-sum-at-least-k/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int ShortestSubarray(int[] A, int K) {
        var SUM = new int[A.Length + 1];
        SUM[0] = 0;
        
        for (var i = 1; i <= A.Length; i++) {
            SUM[i] = SUM[i - 1] + A[i - 1];
        }
        
        var queue = new List<int>();
        var minLen = Int32.MaxValue;
        for (var i = 0; i <= A.Length; i++) {
            while(queue.Count > 0 && SUM[i] - SUM[queue[0]] >= K) {
                minLen = Math.Min(minLen, i - queue[0]);
                queue.RemoveAt(0);
            }
            
            while(queue.Count > 0 && SUM[queue[queue.Count - 1]] >= SUM[i]) {
                queue.RemoveAt(queue.Count - 1);
            }
            
            queue.Add(i);
        }
        
        return minLen == Int32.MaxValue ? -1 : minLen;
    }
}