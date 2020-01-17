/*
 * Link: https://leetcode.com/problems/subarrays-with-k-different-integers/
 * Author: Dung Nguyen Tien (Chris)
 * Reference: lee215
*/

public class Solution {
    public int SubarraysWithKDistinct(int[] A, int K) {
        return AtMost(A, K) - AtMost(A, K - 1);
    }
    
    public int AtMost(int[] A, int K) {
        var map = new Dictionary<int, int>();
        
        foreach(var a in A) {
            if (!map.ContainsKey(a)) map.Add(a, 0);
        }
        
        int begin = 0, end = 0;
        int suba = 0;
        var set = new HashSet<int>();
        while(end < A.Length) {
            if (!set.Contains(A[end])) {
                set.Add(A[end]);
            }
            map[A[end++]]++;
            
            while(set.Count > K) {
                if (--map[A[begin]] == 0) {
                    set.Remove(A[begin]);
                }
                begin++;
            }
            
            suba += (end - begin);
        }
        
        
        return suba;
    }
}