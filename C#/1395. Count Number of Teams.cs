/*
 * Link: https://leetcode.com/problems/count-number-of-teams/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int NumTeams(int[] rating) {
        if (rating.Length < 3) return 0;
        
        var len = rating.Length;
        var greaters = new Dictionary<int, int>();
        var lesses = new Dictionary<int, int>();
        
        for (var i = 0; i < len; i++) {
            greaters.Add(rating[i], 0);
            lesses.Add(rating[i], 0);
            for (var j = i + 1; j < len; j++) {
                if (rating[j] < rating[i]) {
                    lesses[rating[i]]++;
                }
                else if (rating[j] > rating[i]) {
                    greaters[rating[i]]++;
                }
            }
        }
        
        var count = 0;
        
        for (var i = 0; i < len - 1; i++) {
            for (var j = i + 1; j < len; j++) {
                if (rating[j] < rating[i]) {
                    count += lesses[rating[j]];
                }
                else if (rating[j] > rating[i]) {
                    count += greaters[rating[j]];
                }
            }
        }
        
        return count;
    }
}