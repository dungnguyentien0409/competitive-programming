/*
 * Link: https://leetcode.com/problems/diet-plan-performance/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int DietPlanPerformance(int[] calories, int k, int lower, int upper) {
        var queue = new Queue<int>();
        var sum = 0;
        var point = 0;
        
        for (var i = 0; i < calories.Length; i++) {
            var cal = calories[i];
            sum += cal;
            queue.Enqueue(cal);
            
            while(queue.Count > k) {
                sum -= queue.Dequeue();
            }
            
            if (queue.Count == k) {
                if (sum  < lower) {
                    point--;
                }
                else if (sum > upper) {
                    point++;
                }
            }
        }
        
        return point;
    }
}