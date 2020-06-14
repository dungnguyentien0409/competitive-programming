/*
 * Link: https://leetcode.com/problems/minimum-number-of-days-to-make-m-bouquets/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int MinDays(int[] bloomDay, int m, int k) {
        int left = 1, right = (int)Math.Pow(10, 9);
        int n = bloomDay.Length;
        
        if (m * k > n) return -1;
        
        while (left < right) {
            var mid = left - (left - right) / 2;
            var countD = Count(bloomDay, m, k, mid);
            
            if (countD < m) {
                left = mid + 1;
            }
            else {
                right = mid;
            }
        }
        
        return left;
    }
    
    public int Count(int[] bloomDay, int m, int k, int d) {
        int countK = 0, countD = 0;
        
        for(var i = 0; i < bloomDay.Length; i++) {
            if (bloomDay[i] <= d) {
                // bloomDay
                countK++;
                if (countK == k) {
                    countD++;
                    countK = 0;
                }
            }
            else {
                countK = 0;
            }
        }
        
        return countD;
    }
}