/*
 * Link: https://leetcode.com/problems/path-with-maximum-minimum-value/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    int[][] directions = new int[4][] {
        new int[2] { 0, 1 },
        new int[2] { 0, -1 },
        new int[2] { 1, 0 },
        new int[2] { -1, 0 }
    };
    
    // keep pick the next maximum to go on
    public int MaximumMinimumPath(int[][] A) {
        var min = 0;
        var max = (int)Math.Pow(10, 9);
        
        while(min < max) {
            var middle = (min + max + 1) / 2;
            
            if (CheckResult(A, middle)) {
                min = middle;
            }
            else max = middle - 1;
        }
        
        return min;
    }
    
    public bool CheckResult(int[][] A, int result) {
        var rows = A.Length;
        var cols = A[0].Length;
        
        if (A[0][0] < result || A[rows - 1][cols - 1] < result) return false;
        
        var visited = new bool[rows, cols];
        var queue = new Queue<int[]>();
        
        visited[0, 0] = true;
        queue.Enqueue(new int[2] { 0, 0 });
        while(queue.Count > 0) {
            var place = queue.Dequeue();
            
            if (place[0] == rows - 1 && place[1] == cols - 1) return true;
            
            foreach(var d in directions) {
                var nextX = place[0] + d[0];
                var nextY = place[1] + d[1];
                
                if (nextX < 0 || nextX >= rows
                   || nextY < 0 || nextY >= cols
                   || visited[nextX, nextY]
                   || A[nextX][nextY] < result) continue;
                
                visited[nextX, nextY] = true;
                queue.Enqueue(new int[2] { nextX, nextY });
            }
        }
        
        return false;
    }
}