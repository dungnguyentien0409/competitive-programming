/*
 * Link: https://leetcode.com/problems/angle-between-hands-of-a-clock/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public double AngleClock(int hour, int minutes) {
        double h = (hour%12 * 30) + ((double)minutes/60 * 30);
        double m = minutes * 6;
        
        double angle = Math.Abs(m - h);
        
        if (angle > 180) angle = 360.0 - angle;
        
        return angle;
    }
}