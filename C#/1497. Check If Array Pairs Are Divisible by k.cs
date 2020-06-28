/*
 * Link: https://leetcode.com/problems/check-if-array-pairs-are-divisible-by-k/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public bool CanArrange(int[] arr, int k) {
        var mod = new int[k];
        
        foreach(var n in arr) {
            if (n >= 0) {
                mod[n % k]++;
            }
            else {
                mod[(k + n % k) % k]++;
            }
        }
    
        
        int left = 1, right = k - 1;
        while(left < right && mod[left++] == mod[right--]);
        
        if (left == right) return mod[left] % 2 == 0 && left * 2 == k;
        
        return left > right;
    }
}