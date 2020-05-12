/*
 * Link: https://leetcode.com/problems/candy/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int Candy(int[] ratings) {
        var candies = new int[ratings.Length];
        Array.Fill(candies, 1);
        
        for (var i = 1; i < ratings.Length; i++) {
            if (ratings[i] > ratings[i - 1]) {
                candies[i] = candies[i - 1] + 1;
            }
        }
        
        for(var i = ratings.Length - 2; i >= 0; i--) {
            if (ratings[i] > ratings[i + 1] && candies[i] <= candies[i + 1]) {
                candies[i] = candies[i + 1] + 1;
            }
        }
        
        var sum = 0;
        foreach(var c in candies) sum += c;
        
        return sum;
    }
}