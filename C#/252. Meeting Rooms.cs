/*
 * Link: https://leetcode.com/problems/meeting-rooms/
 * Author: Dung Nguyen Tien (Chris)
*/
public class Solution {
    public bool CanAttendMeetings(int[][] intervals) {
        Array.Sort(intervals, delegate(int[] i1, int[] i2) {
            if (i1[0] == i2[0]) return i1[1] - i2[1];
            
            return i1[0] - i2[0];
        });
            
        for (var i = 0; i < intervals.Length - 1; i++) {
            if (intervals[i][1] > intervals[i + 1][0]) return false;
        }
        
        return true;
    }
}