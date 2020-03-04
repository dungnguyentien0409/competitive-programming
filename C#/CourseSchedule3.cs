/*
 * Problem: https://leetcode.com/problems/course-schedule-iii/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int ScheduleCourse(int[][] courses) {
        Array.Sort<int[]>(courses, delegate(int[] a, int[] b) {
            if (a[1] == b[1]) return a[0] - b[0];
            return a[1] - b[1];
        });
        
        var current = 0;
        var PriorityQueue = new List<int>();
        foreach(var course in courses) {
            int duration = course[0];
            int end = course[1];
            
            // foreach course, put the duration in ordered list
            // then calculate the time, if the time exceed, pop the biggest duration
            var index = PriorityQueue.BinarySearch(duration);
            
            if (index < 0) index = ~index;
            PriorityQueue.Insert(index, duration);
            current += duration;
            
            if (current > end) {
                current -= PriorityQueue[PriorityQueue.Count - 1];
                PriorityQueue.RemoveAt(PriorityQueue.Count - 1);
            }
        }
        
        return PriorityQueue.Count;
    }
}