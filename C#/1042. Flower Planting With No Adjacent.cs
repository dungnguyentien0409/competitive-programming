/*
 * Link: https://leetcode.com/problems/flower-planting-with-no-adjacent/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int[] GardenNoAdj(int N, int[][] paths) {
        var map = CreateMap(N, paths);
        var res = new int[N];
        
        for (var i = 1; i <= N; i++) {
            var flowers = new int[5];
            
            foreach(var neighbor in map[i]) {
                flowers[res[neighbor - 1]] = 1;
            }
            
            for (var j = 1; j <= 4; j++) {
                if (flowers[j] == 0) {
                    res[i - 1] = j;
                }
            }
        }
        
        return res;
    }
    
    public Dictionary<int, List<int>> CreateMap(int N, int[][] paths) {
        var map = new Dictionary<int, List<int>>();
        
        for (var i = 1; i <= N; i++) map.Add(i, new List<int>());
        
        foreach(var path in paths) {
            map[path[0]].Add(path[1]);
            map[path[1]].Add(path[0]);
        }
        
        return map;
    }
}