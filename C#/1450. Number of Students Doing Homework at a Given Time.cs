/*
 * Link: https://leetcode.com/problems/number-of-students-doing-homework-at-a-given-time/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int BusyStudent(int[] startTime, int[] endTime, int queryTime) {
        int count = 0;
        int students = startTime.Length;
        
        for(var i = 0; i < students; i++) {
            if (startTime[i] <= queryTime && endTime[i] >= queryTime) {
                count++;
            }
        }
        
        return count;
    }
}