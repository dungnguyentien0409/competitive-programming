/*
 * Link: https://leetcode.com/problems/relative-sort-array/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int[] RelativeSortArray(int[] arr1, int[] arr2) {
        var map = new Dictionary<int, int>();
        
        foreach(var n in arr1) {
            if (!map.ContainsKey(n)) map.Add(n, 0);
            
            map[n]++;
        }
        
        var index = 0;
        foreach(var n in arr2) {
            while (map[n]-- > 0) {
                arr1[index++] = n;
            }
        } 
        
        foreach(var key in map.Keys.OrderBy(o => o).ToList()) {
            while(map[key]-- > 0) {
                arr1[index++] = key;
            }
        }
        
        return arr1;
    }
}