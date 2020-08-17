/*
 * Link: https://leetcode.com/problems/distribute-candies-to-people/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int[] DistributeCandies(int candies, int num_people) {
        var res = new int[num_people];
        
        int i = 0;
        while(candies > 0) {
            res[i % num_people] += Math.Min(candies, i + 1);
            
            candies -= (i + 1);
            i++;
        }
        
        return res;
    }
}