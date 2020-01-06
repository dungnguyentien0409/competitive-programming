/*
 * Link: https://leetcode.com/problems/meeting-rooms-ii/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int MinMeetingRooms(int[][] intervals) {
        Array.Sort(intervals, delegate(int[] i1, int[] i2) {
            if (i1[0] == i2[0]) return i1[1] - i2[1];
            
            return i1[0] - i2[0];
        });
        
        var count = 0;
        var currents = new List<int>();
        currents.Add(0);
        
        foreach(var interval in intervals) {
            // pick the room has min end time
            var begin = interval[0];
            var end = interval[1];
            
            // Remove all rooms are done using
            while (currents.Count > 0 && currents[0] <= begin) {
                currents.RemoveAt(0);
            }
            
            var index = currents.BinarySearch(end);
            if (index < 0) index = ~index;
            currents.Insert(index, end);
            count = Math.Max(count, currents.Count);
        }
        
        return count;
    }
}