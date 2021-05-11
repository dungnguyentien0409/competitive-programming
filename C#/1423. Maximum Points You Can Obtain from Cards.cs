/*
 * Link: https://leetcode.com/problems/maximum-points-you-can-obtain-from-cards/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int MaxScore(int[] cardPoints, int k) {
        int len = cardPoints.Length;
        
        int start = len - k, end = start + 2 * k;
        
        int res = 0, sum = 0, cur = start;
        while(cur < end) {
            sum += cardPoints[cur++ % len];
            
            if (cur - start == k) {
                res = Math.Max(res, sum);
                sum -= cardPoints[start++ % len];
            }
        }
        
        return res;
    }
}