/*
 * Link: https://leetcode.com/problems/partition-labels/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public IList<int> PartitionLabels(string S) {
        var map = new Dictionary<char, int>();
        
        for (var i = 0; i < S.Length; i++) {
            if (!map.ContainsKey(S[i])) map.Add(S[i], 0);
            
            map[S[i]] = i;
        }
        
        var res = new List<int>();
        int start = -1, end = -1;
        
        for (var i = 0; i < S.Length; i++) {
            end = Math.Max(end, map[S[i]]);
            
            if (end == i) {
                res.Add(end - start);
                
                start = end;
            }
        }
        
        return res;
    }
}