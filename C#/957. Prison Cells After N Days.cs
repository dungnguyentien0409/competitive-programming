/*
 * Link: https://leetcode.com/problems/prison-cells-after-n-days/
 * Idea: lee215
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int[] PrisonAfterNDays(int[] cells, int N) {
        var map = new Dictionary<string, int>();
        
        while(N > 0) {
            var tmp = new int[cells.Length];
            var key = GetKey(cells);
            
            if (!map.ContainsKey(key)) map.Add(key, 0);
            map[key] = N--;
            
            for (var i = 1; i < cells.Length - 1; i++) {
                tmp[i] = (cells[i - 1] == cells[i + 1]) ? 1 : 0;
            }
            
            if (map.ContainsKey(GetKey(tmp))) {
                var day = map[GetKey(tmp)];
                N = N % (N - day);
            }
            
            cells = tmp;
        }
        
        return cells;
    }
    
    public string GetKey(int[] cells) {
        var key = string.Join("", cells);
        
        return key;
    }
}