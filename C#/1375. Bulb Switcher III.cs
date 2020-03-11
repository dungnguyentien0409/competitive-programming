/*
 * Link: https://leetcode.com/problems/bulb-switcher-iii/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int NumTimesAllBlue(int[] light) {
        var sorted = new List<int>();
        int count = 0;
        
        foreach(var l in light) {
            var index = BinarySearch(sorted, l);
            sorted.Insert(index, l);
            
            var last = sorted.Count - 1;
            if (sorted[last] == sorted.Count) {
                // all left are turn on
                count++;
            }
        }
        
        return count;
    }
    
    private int BinarySearch(List<int> sorted, int light) {
        if (sorted.Count == 0) return 0;
        
        int left = 0, right = sorted.Count - 1;
        
        while(left < right) {
            var mid = (left + right) / 2;
            
            if (sorted[mid] < light) left = mid + 1;
            else right = mid;
        }
        
        if (sorted[left] < light) return left + 1;
        return left;
    }
}