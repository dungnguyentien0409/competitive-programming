/*
 * Link: https://leetcode.com/problems/max-chunks-to-make-sorted-ii/
 * Idea: lee215
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int MaxChunksToSorted(int[] arr) {
        int len = arr.Length;
        var sorted = new int[len];
        Array.Copy(arr, sorted, len);
        Array.Sort(sorted);
        
        int s1 = 0, s2 = 0, res = 0;
        for(var i = 0; i < len; i++) {
            s1 += arr[i];
            s2 += sorted[i];
            
            if (s1 == s2) res++;
        }
        
        return res;
    }
}