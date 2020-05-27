/*
 * Link: https://leetcode.com/problems/meeting-scheduler/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public IList<int> MinAvailableDuration(int[][] slots1, int[][] slots2, int duration) {
        Array.Sort(slots1, delegate(int[] a, int[] b) { 
            if (a[0] == b[0]) return a[1] - b[1];
            return a[0] - b[0];
        });
        Array.Sort(slots2, delegate(int[] a, int[] b) { 
            if (a[0] == b[0]) return a[1] - b[1];
            return a[0] - b[0];
        });
        
        int ia = 0, ib = 0;
        while(ia < slots1.Length && ib < slots2.Length) {
            var start = Math.Max(slots1[ia][0], slots2[ib][0]);
            var end = Math.Min(slots1[ia][1], slots2[ib][1]);
            
            if (end - start >= duration) {
                return new int[2] { start, start + duration };
            }
            else if (slots1[ia][0] <= slots2[ib][0] && slots1[ia][1] <= slots2[ib][1]) {
                ia++;
            }
            else {
                ib++;
            }
        }
        
        return new int[0];
    }
}