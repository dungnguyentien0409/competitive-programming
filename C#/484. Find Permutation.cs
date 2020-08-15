/*
 * Link: https://leetcode.com/problems/find-permutation/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int[] FindPermutation(string s) {
        var res = new int[s.Length + 1];
        for (var i = 0; i < res.Length; i++) res[i] = i + 1;
        
        for (var r = 0; r < s.Length; r++) {
            if (s[r] == 'D') {
                int l = r;
                
                while(r < s.Length && s[r] == 'D') r++;
                Reverse(res, l, r);
            }
        }
        
        return res;
    }
    
    public void Reverse(int[] arr, int left, int right) {
        while(left < right) {
            Swap(arr, left++, right--);
        }
    }
    
    public void Swap(int[] arr, int left, int right) {
        if (left == right) return;
        
        var tmp = arr[left];
        arr[left] = arr[right];
        arr[right] = tmp;
    }
}