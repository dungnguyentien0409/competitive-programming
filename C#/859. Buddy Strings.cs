/*
 * Link: https://leetcode.com/problems/buddy-strings/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public bool BuddyStrings(string a, string b) {
        if (a.Length != b.Length) return false;
        
        if (a == b) {
            return (new HashSet<char>(a)).Count != a.Length;
        }
        
        var check = new List<int>();
        for (var i = 0; i < a.Length; i++) {
            if (a[i] != b[i]) {
                check.Add(i);
            }
        }
        
        return check.Count == 2 &&
            a[check[0]] == b[check[1]] && a[check[1]] == b[check[0]];
    }
}