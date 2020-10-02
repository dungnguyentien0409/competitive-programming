/*
 * Link: https://leetcode.com/problems/maximum-distance-in-arrays/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int MaxDistance(IList<IList<int>> arrays) {
        int min = arrays[0][0], max = arrays[0][arrays[0].Count - 1];
        int diff = 0;
        
        for (var i = 1; i < arrays.Count; i++) {
            var arr = arrays[i];
            int first = arr[0];
            int last = arr[arr.Count - 1];
            
            diff = Math.Max(Math.Max(diff, last - min), Math.Max(diff, max - first));
            
            min = Math.Min(min, first);
            max = Math.Max(max, last);
        }
        
        return diff;
    }
}