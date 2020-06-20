/*
 * Link: https://leetcode.com/problems/h-index/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int HIndex(int[] citations) {
        // h <= N
        var N = citations.Length;
        var buckets = new int[N + 1];
        
        for (var i = 0; i < citations.Length; i++) {
            var citation = citations[i];
            
            if (citation >= N) buckets[N]++;
            else {
                buckets[citation]++;
            }
        }
        
        var count = 0;
        for (var i = N; i >= 0; i--) {
            count += buckets[i];
            
            if (count >= i) return i;
        }
        
        return 0;
    }
}