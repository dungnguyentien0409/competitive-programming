/*
 * Link: https://leetcode.com/problems/shortest-word-distance/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int ShortestDistance(string[] words, string word1, string word2) {
        int i1 = -words.Length, i2 = words.Length;
        int d = words.Length;
        
        for (var i = 0; i < words.Length; i++) {
            var w = words[i];
            
            if (w.CompareTo(word1) == 0) {
                i1 = i;
            }
            else if(w.CompareTo(word2) == 0) {
                i2 = i;
            }
            
            d = Math.Min(d, Math.Abs(i1 - i2));
        }
        
        return d;
    }
}