/*
 * Problem: https://leetcode.com/problems/minimum-time-visiting-all-points/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int MinTimeToVisitAllPoints(int[][] points) {
        if (points.Length == 0) return 0;
        
        var duration = 0;
        var current = points[0];
        
        for (var i = 1; i < points.Length; i++) {
            var target = points[i];
            
            while(current[0] != target[0] || current[1] != target[1]) {
                current = nextMove(current, target);
                ++duration;
                
            }
        }
        
        return duration;
    }
    
    public void Print(int[] current) {
        Console.WriteLine(current[0] + "-" + current[1]);
    }
    
    public int[] nextMove(int[] current, int[] target) {
        var next = new int[5];
        
        // find the next step of x and y
        next[0] = current[0] + nextMoveHelper(current[0], target[0]);
        next[1] = current[1] + nextMoveHelper(current[1], target[1]);
        
        return next;
    }
    
    public int nextMoveHelper(int x1, int x2) {
        if (x1 == x2) return 0;
        else if (x1 < x2) return 1;
        else return -1;
    }
}