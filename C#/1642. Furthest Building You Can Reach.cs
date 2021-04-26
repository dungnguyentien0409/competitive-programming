/*
 * Link: https://leetcode.com/problems/furthest-building-you-can-reach/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int FurthestBuilding(int[] heights, int bricks, int ladders) {
        var list = new List<int>();
        
        for(var i = 1; i < heights.Length; i++) {
            if (heights[i] < heights[i - 1]) continue;
            
            var d = heights[i] - heights[i - 1];
            var index = list.BinarySearch(d);
            if (index < 0) index = ~index;
            
            list.Insert(index, d);
            
            if (list.Count > ladders) {
                bricks -= list[0];
                list.RemoveAt(0);
            }
            
            if (bricks < 0) return i - 1;
        }
        
        return heights.Length - 1;
    }
}