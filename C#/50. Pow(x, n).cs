/*
 * Link: https://leetcode.com/problems/powx-n/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public double MyPow(double x, int n) {
        if (n == 0) return 1;
        
        if (n < 0) {
            n = -n;
            x = 1 / x;
        }
        
        var res =  n % 2 == 0 ?
            MyPow(x * x, n / 2) : x * MyPow(x * x, n / 2);
        
        return double.IsInfinity(res) ? 0 : res;
    }
}