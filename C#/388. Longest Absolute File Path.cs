/*
 * Link: https://leetcode.com/problems/longest-absolute-file-path/
 * Author: Dung Nguyen Tien (Chris)
*/

using System.Text.RegularExpressions;

public class Solution {
    public int LengthLongestPath(string input) {
        var maxLen = 0;
        var pathLength = new Dictionary<int, int>();
        var lines = input.Split("\n");
        
        pathLength.Add(0, 0);
        foreach(var line in lines) {
            var re = new Regex("\t");
            var name = re.Replace(line, "");
            var depth = line.Length - name.Length;
            
            if (name.Contains(".")) {
                maxLen = Math.Max(maxLen, pathLength[depth] + name.Length);
            }
            else {
                pathLength[depth + 1] = pathLength[depth] + name.Length + 1;
            }
        }
        
        return maxLen;
    }
}