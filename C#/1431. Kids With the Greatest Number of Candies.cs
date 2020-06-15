/*
 * Link: https://leetcode.com/problems/kids-with-the-greatest-number-of-candies/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        var max = 0;
        foreach(var n in candies) max = Math.Max(n, max);
        
        var res = new bool[candies.Length];
        
        for (var i = 0; i < candies.Length; i++) {
            res[i] = candies[i] + extraCandies >= max;
        }
        
        return res;
    }
}