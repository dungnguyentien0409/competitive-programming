/*
 * Link: https://leetcode.com/problems/play-with-chips/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int MinCostToMoveChips(int[] chips) {
        int odd = 0, even = 0;
        
        foreach(var pos in chips) {
            if (pos % 2 == 0) even++;
            else odd++;
        }
        
        return Math.Min(odd, even);
    }
}