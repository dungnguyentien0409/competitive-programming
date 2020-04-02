/*
 * Link: https://leetcode.com/problems/flip-game/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public IList<string> GeneratePossibleNextMoves(string s) {
        var result = new List<string>();
        
        for (var i = 1; i < s.Length; i++) {
            // length = end - start + 1;
            if (s.Substring(i - 1, 2) == "++") {
                result.Add(s.Substring(0, (i - 2) - 0 + 1)
                          + "--"
                          + s.Substring(i + 1, s.Length - 1 - (i + 1) + 1));
            }
        }
        
        return result;
    }
}