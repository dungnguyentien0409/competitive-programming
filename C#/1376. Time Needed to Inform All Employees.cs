/*
 * Link: https://leetcode.com/problems/time-needed-to-inform-all-employees/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int NumOfMinutes(int n, int headID, int[] manager, int[] informTime) {
        var map = CreateMap(n, manager, informTime);
        var time = bfs(n, map, headID);
        
        return time;
    }
    
    public int bfs(int n, Dictionary<int, List<int[]>> map, int headID) {
        var queue = new Queue<int>();
        var times = new int[n];
        
        Array.Fill(times, 0);
        queue.Enqueue(headID);
        while(queue.Count > 0) {
            var len = queue.Count;
            
            for (var i = 0; i < len; i++) {
                var employee = queue.Dequeue();
                var subordinates = map[employee];
                
                foreach(var subordinate in subordinates) {
                    queue.Enqueue(subordinate[0]);
                    times[subordinate[0]] = times[employee] + subordinate[1];
                }
            }
        }
        
        var f_time = 0;
        
        foreach(var time in times) f_time = Math.Max(f_time, time);
        
        return f_time;
    }
    
    public Dictionary<int, List<int[]>> CreateMap(int n, int[] manager, int[] informTime) {
        var map = new Dictionary<int, List<int[]>>();
        
        for (var i = -1; i < n; i++) {
            map.Add(i, new List<int[]>());
        }
        
        for (var i = 0; i < n; i++) {
            var m = manager[i];
            int time = 0;
            
            if (m != -1) time = informTime[m];
            map[m].Add(new int[2] { i, time });
        }
        
        return map;
    }
}