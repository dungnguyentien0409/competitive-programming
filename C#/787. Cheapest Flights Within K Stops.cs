/*
 * Link: https://leetcode.com/problems/cheapest-flights-within-k-stops/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int K) {
        var res = Int32.MaxValue;
        var distance = new int[n];
        Array.Fill(distance, Int32.MaxValue);
        
        distance[src] = 0;
        for (var i = 0; i <= K; i++) {
            var current = new int[n];
            Array.Fill(current, Int32.MaxValue);
            
            foreach(var flight in flights) {
                var start = flight[0];
                var end = flight[1];
                var dis = flight[2];
                
                if (distance[start] != Int32.MaxValue) {
                    current[end] = Math.Min(current[end], distance[start] + dis);
                }
            }
            
            distance = current;
            res = Math.Min(res, distance[dst]);
        }
        
        return res != Int32.MaxValue ? res : -1;
    }
}