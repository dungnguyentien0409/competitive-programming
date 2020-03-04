/*
 * Link: https://leetcode.com/problems/course-schedule-ii/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    // use topology sort
    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        buildMap(numCourses, prerequisites);
        
        var st = TopologySort(numCourses);
        
        Console.WriteLine(st.Count);
        if (st.Count != numCourses) return new int[0];
        
        var res = new int[numCourses];
        for (var i = 0; i < numCourses; i++) {
            res[i] = st.Pop();
        }
        
        return res;
    }
    
    Dictionary<int, List<int>> map;
    public void buildMap(int numCourses, int[][] prerequisites) {
        map = new Dictionary<int, List<int>>();
        
        for(var i = 0; i < numCourses; i++) map[i] = new List<int>();
        
        foreach(var item in prerequisites) {
            map[item[1]].Add(item[0]);
        }
    }
    
    public Stack<int> TopologySort(int numCourses) {
        var st = new Stack<int>();
        var visited = new int[numCourses];
        Array.Fill(visited, 0);
        
        for(var i = 0; i < numCourses; i++) {
            if (visited[i] == 0) {
                if (!TopologySortUtil(i, ref visited, ref st)) return new Stack<int>();
            }
        }
        
        return st;
    }
    
    public bool TopologySortUtil(int current, ref int[] visited, ref Stack<int> st) {
        visited[current] = 1;
        
        foreach(var nextCourse in map[current]) {
            if (visited[nextCourse] == 1) return false;
            if (visited[nextCourse] == 0) {
                if(!TopologySortUtil(nextCourse, ref visited, ref st)) {
                    return false;
                };
            }
        }
        
        visited[current] = 2;
        st.Push(current);
        
        return true;
    }
}