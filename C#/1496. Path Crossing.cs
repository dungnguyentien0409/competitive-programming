/*
 * Link: https://leetcode.com/problems/path-crossing/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public bool IsPathCrossing(string path) {
        var directions = CreateDirections();
        var pos = new int[] { 0, 0 };
        var visited = new HashSet<string>();
        
        visited.Add("00");
        foreach(var p in path) {
            var d = directions[p];
            
            var nextX = pos[0] + d[0];
            var nextY = pos[1] + d[1];
            var key = nextX.ToString() + nextY.ToString();
            
            if (visited.Contains(key)) return true;
            
            visited.Add(key);
            pos[0] = nextX;
            pos[1] = nextY;
        }
        
        return false;
    }
    
    public Dictionary<char, int[]> CreateDirections() {
        var directions = new Dictionary<char, int[]>();
        
        directions.Add('N', new int[] { -1, 0 });
        directions.Add('S', new int[] { 1, 0 });
        directions.Add('E', new int[] { 0, 1 });
        directions.Add('W', new int[] { 0, -1 });
        
        return directions;
    }
}