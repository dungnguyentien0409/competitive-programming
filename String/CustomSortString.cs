// Problem: https://leetcode.com/problems/custom-sort-string/submissions/
// Author: Dung Nguyen Tien (Chris)

public class Solution {
    public string CustomSortString(string S, string T) {
        var dict = new Dictionary<char, int>();
        
        var i = 0;
        foreach (var c in S) {
            if (!dict.ContainsKey(c)) {
                dict.Add(c, i++);
            }
        }
        
        var customSortArray = T.ToCharArray();
        Array.Sort(customSortArray, (x, y) => {
            var ix = dict.ContainsKey(x) ? dict[x] : int.MaxValue;
            var iy = dict.ContainsKey(y) ? dict[y] : int.MaxValue;
            
            return ix - iy;
        });
        
        T = new string(customSortArray);
        return T;
    }
}