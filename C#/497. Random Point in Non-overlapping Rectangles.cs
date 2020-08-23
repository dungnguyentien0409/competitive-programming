/*
 * Link: https://leetcode.com/problems/random-point-in-non-overlapping-rectangles/submissions/
 * Idea: quico14
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    SortedDictionary<int, int> map;
    int[][] arr;
    int sum;
    Random rn = new Random();
    
    public Solution(int[][] rects) {
        arr = rects;
        map = new SortedDictionary<int, int>();
        sum = 0;
        
        for (var i = 0; i < rects.Length; i++) {
            var rect = rects[i];
            
            sum += (rect[2] - rect[0] + 1) * (rect[3] - rect[1] + 1);
            map[sum] = i;
        }
    }
    
    public int[] Pick() {
        var solutions = rn.Next(sum + 1);
        
        var recIndex = map.First(x => x.Key >= solutions).Value;
        
        return Pick(arr[recIndex]);
    }
    
    public int[] Pick(int[] rec) {
        var x = rn.Next(rec[0], rec[2] + 1);
        var y = rn.Next(rec[1], rec[3] + 1);
        
        return new int[] { x, y };
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(rects);
 * int[] param_1 = obj.Pick();
 */