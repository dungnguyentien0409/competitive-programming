/*
 * Link: https://leetcode.com/problems/pour-water/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int[] PourWater(int[] heights, int V, int K) {
        var len = heights.Length;
        var j = K;
        
        // j point to current position
        for (var i = 0; i < V; i++) {
            while(j > 0 && heights[j] >= heights[j - 1]) {
                // move left
                j--;
            }
            while(j < len - 1 && heights[j] >= heights[j + 1]) {
                // move right
                j++;
            }
            while (j > K && heights[j] == heights[j - 1]) {
                // back to the right after the K
                j--;
            }
            
            Console.WriteLine(j + " " + heights[j]);
            heights[j] += 1;
        }
        
        return heights;
    }
}