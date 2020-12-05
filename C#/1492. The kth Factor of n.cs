/*
 * Link: https://leetcode.com/problems/the-kth-factor-of-n/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int KthFactor(int n, int k) {
        for(var i = 1; i < Math.Sqrt(n); i++){
            if(n % i == 0 && --k == 0){
                return i;
            }
        }

        for(var i = (int)Math.Sqrt(n); i >= 1; i--){
            if(n % i ==0 && --k == 0){
                return n / i;
            }
        }
        return -1;
    }
}