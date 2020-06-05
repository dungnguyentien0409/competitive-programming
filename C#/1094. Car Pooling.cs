/*
 * Link: https://leetcode.com/problems/car-pooling/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public bool CarPooling(int[][] trips, int capacity) {
        var custom = GenerateByTime(trips);
        var passengers = 0;
        
        foreach(var item in custom) {
            passengers += item[1];
            
            if (passengers > capacity) return false;
        }
        
        return true;
    }
    
    public List<int[]> GenerateByTime(int[][] trips) {
        var res = new List<int[]>();
        
        foreach(var trip in trips) {
            res.Add(new int[2] { trip[1], trip[0] });
            res.Add(new int[2] { trip[2], -trip[0] });
        }
        
        res.Sort(delegate(int[] a, int[] b) {
            if (a[0] == b[0]) return a[1] - b[1];
            
            return a[0] - b[0];
        });
        return res;
    }
}