/*
 * Link: https://leetcode.com/problems/compare-version-numbers/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int CompareVersion(string version1, string version2) {
        var arr1 = version1.Split(".");
        var arr2 = version2.Split(".");
        int len1 = arr1.Length, len2 = arr2.Length;
        int len = Math.Max(len1, len2);
        
        int index = 0;
        while(index < len) {
            var n1 = index < len1 ? int.Parse(arr1[index]) : 0;
            var n2 = index < len2 ? int.Parse(arr2[index]) : 0;
            
            if (n1 != n2) {
                return n1 < n2 ? -1 : 1;
            }
            index++;
        }
        
        return 0;
    }
}