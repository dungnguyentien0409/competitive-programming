/*
 * Problem: https://leetcode.com/problems/network-delay-time/
 * Author: Dung Nguyen Tien (Chris)
*/
public class Solution {
    // use Dijkstra
    public int NetworkDelayTime(int[][] times, int N, int K) {
        BuildMap(times, N);
        var res = Dijkstra(N, K);
        
        return res;
    }
    
    Dictionary<int, List<int[]>> map;
    bool[] visited;
    int[] distance;
    int vertex;
    
    public int Dijkstra(int N, int start) {
        vertex = N;
        visited = new bool[vertex + 1];
        distance = new int[vertex + 1];
        Array.Fill(visited, false);
        Array.Fill(distance, Int32.MaxValue);
        
        distance[start] = 0;
        for (var count = 1; count <= vertex; count++) {
            var u = GetMinVertex();
            if (u == -1) break;
            visited[u] = true;
            
            foreach(var edge in map[u]) {
                var v = edge[0];
                var dis = edge[1];
                
                if (distance[v] > distance[u] + dis) {
                    distance[v] = distance[u] + dis;
                }
            }
        }
        
        var time = 0;
        for(var i = 1; i <= vertex; i++) {
            var d = distance[i];
            Console.Write(d + " ");
            if (d == Int32.MaxValue) return -1;
            time = Math.Max(time, d);
        }
        
        return time;
    }
    
    public int GetMinVertex() {
        var min = Int32.MaxValue;
        var iMin = -1;
        
        for (var i = 1; i <= vertex; i++) {
            if (!visited[i] && distance[i] < min) {
                min = distance[i];
                iMin = i;
            }
        }
        
        return iMin;
    }
    
    public void BuildMap(int[][] times, int N) {
        map = new Dictionary<int, List<int[]>>();
        
        for (var i = 0; i <= N; i++) {
            map.Add(i, new List<int[]>());
        }
        
        foreach(var item in times) {
            var source = item[0];
            var target = item[1];
            var distance = item[2];
            
            map[source].Add(new int[2] {target, distance});
        }
    }
    
    public void PrintMap() {
        for(int index = 0; index < map.Count; index++) {
            var item = map.ElementAt(index);
            Console.WriteLine("source: " + item.Key);
            foreach(var obj in item.Value) {
                Console.WriteLine(obj[0] + " " + obj[1]);
            }
        }
    }
}