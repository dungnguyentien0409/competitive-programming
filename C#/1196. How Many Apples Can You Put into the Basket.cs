/*
 * Link: https://leetcode.com/problems/how-many-apples-can-you-put-into-the-basket/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int MaxNumberOfApples(int[] arr) {
        Array.Sort(arr, delegate(int a, int b) {
            return a - b;
        });
            
        int sum = 0;
        int i = 0;
        for (i = 0; i < arr.Length; i++) {
            sum += arr[i];
            
            if (sum > 5000) return i;
        }
        
        return i;
    }
}