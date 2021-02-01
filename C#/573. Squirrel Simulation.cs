/*
 * Link:https://leetcode.com/problems/squirrel-simulation
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int MinDistance(int height, int width, int[] tree, int[] squirrel, int[][] nuts) {
        int sum = 0;
        int diff = Int32.MinValue;
        
        foreach(var nut in nuts) {
            var dist = GetDistance(nut, tree);
            sum += 2 * dist;
            
            diff = Math.Max(diff,
                               dist - GetDistance(squirrel, nut));
        }
        
        return sum - diff;
    }
    
    public int GetDistance(int[] a, int[] b) {
        return Math.Abs(a[0] - b[0]) + Math.Abs(a[1] - b[1]);
    }
}