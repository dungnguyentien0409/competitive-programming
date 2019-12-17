/*
 * Problem: https://leetcode.com/problems/course-schedule/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    // Topology Sort using BFS
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        map = BuildMap(numCourses, prerequisites);
        var check = TopologySort(numCourses);
        Console.WriteLine(check);
        
        return check;
    }
    
    public Dictionary<int, List<int>> map;
    public int[] degree;
    public Dictionary<int, List<int>> BuildMap(int numCourses, int[][] prerequisites) {
        map = new Dictionary<int, List<int>>();
        degree = new int[numCourses];
        Array.Fill(degree, 0);
        
        for (var i = 0; i < numCourses; i++) map.Add(i, new List<int>());
        
        foreach(var item in prerequisites) {
            var pre = item[1];
            var course = item[0];
            
            map[pre].Add(course);
            degree[course]++;
        }
        return map;
    }
    
    public bool TopologySort(int numCourses) {
        var queue = new Queue<int>();
        var count = 0;
        for (var i = 0; i < numCourses; i++) {
            if (degree[i] == 0) queue.Enqueue(i);
        }
        
        while(queue.Count > 0) {
            var u = queue.Dequeue();
            
            foreach(var next in map[u]) {
                if(--degree[next] == 0) queue.Enqueue(next);
            }
            
            count++;
        }
        
        return count == numCourses;
    }
}