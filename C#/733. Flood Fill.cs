/*
 * Link: https://leetcode.com/problems/flood-fill/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int newColor) {
        if (image.Length == 0 || image[0].Length == 0) return image;
        
        var directions = new int[4][] {
            new int[2] { 0, 1 },
            new int[2] { 0, -1 },
            new int[2] { 1, 0 },
            new int[2] { -1, 0 }
        };
        var oriColor = image[sr][sc];
        var visited = new HashSet<string>();
        
        Filling(image, sr, sc, oriColor, newColor, directions, visited);
        
        return image;
    }
    
    public void Filling(int[][] image, int x, int y, int oriColor, int newColor, int[][] directions, HashSet<string> visited) {
        if (x < 0 || y < 0
           || x >= image.Length || y >= image[0].Length
           || image[x][y] != oriColor
           || visited.Contains(x.ToString() + y.ToString())) return;
        
        image[x][y] = newColor;
        visited.Add(x.ToString() + y.ToString());
        
        foreach(var d in directions) {
            var nextX = x + d[0];
            var nextY = y + d[1];
            
            //Console.WriteLine(d[0] + " " + d[1] + " " + nextX + " " + nextY);
            Filling(image, nextX, nextY, oriColor, newColor, directions, visited);
        }
    }
}