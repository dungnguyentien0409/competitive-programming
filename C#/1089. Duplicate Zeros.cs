/*
 * Link: https://leetcode.com/problems/duplicate-zeros/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public void DuplicateZeros(int[] arr) {
        var zeros = CountZero(arr);
        
        if (zeros == 0) return;
        
        for (var i = arr.Length - 1; i >= 0; i--) {
            var j = i + zeros;
            
            if (arr[i] == 0) {
                zeros--;
            }
            
            if (j < arr.Length) {
                if (i != j) {
                    arr[j] = arr[i];
                    arr[i] = 0;
                }
            } 
            else {
                arr[i] = 0;
            }
        }
    }
    
    public int CountZero(int[] arr) {
        var count = 0;
        
        foreach(var n in arr) {
            if (n == 0) {
                count++;
            }
        }
        
        return count;
    }
}