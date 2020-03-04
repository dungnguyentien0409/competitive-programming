/*
 * Problem: https://leetcode.com/problems/cheapest-flights-within-k-stops/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    // use Bellman algorithm
    public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int K) {
        var res = Bellman(n, flights, src, dst, K);
        
        return res;
    }
    
    public int Bellman(int n, int[][] flights, int src, int dst, int K) {
        var distance = new int[n];
        Array.Fill(distance, Int32.MaxValue);
        distance[src] = 0;
        var res = distance[dst];
        
        // after loop K times
        // if there is the distance fro src to dst with at most K edges
        // the distace[dst] will be the shortest
        for (var i = 0; i <= K; i++) {
            // to make sure each loop for one peak
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
            
            Console.WriteLine(current[dst]);
            res = Math.Min(res, current[dst]);
            distance = current;
        }
        
        return res != Int32.MaxValue ? res : -1;
    }
}