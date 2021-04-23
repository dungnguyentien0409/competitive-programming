/*
 * Link: https://leetcode.com/problems/brick-wall/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int LeastBricks(IList<IList<int>> wall) {
        var borders = GetBorders(wall);
        var map = new Dictionary<int, int>();
        
        int max = 0;
        for (var i = 0; i < borders.Count; i++) {
            for (var j = 0; j < borders[i].Count; j++) {
                var key = borders[i][j];
                
                if (!map.ContainsKey(key)) map.Add(key, 0);
                map[key]++;
                max = Math.Max(max, map[key]);
            }
        }
        
        return wall.Count - max;
    }
    
    public List<IList<int>> GetBorders(IList<IList<int>> wall){
        var borders = new List<IList<int>>();
        
        for(var i = 0; i < wall.Count; i++) {
            var cur = new List<int>();
            int b = 0;
            
            for (var j = 0; j < wall[i].Count; j++) {
                b += wall[i][j];
                
                if (j < wall[i].Count -1) {
                    cur.Add(b);
                }
            }
            
            borders.Add(cur);
        }
        
        return borders;
    }
}