/*
 * Link: https://leetcode.com/problems/shortest-word-distance/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int ShortestDistance(string[] words, string word1, string word2) {
        int i1 = -1, i2 = -1;
        var shortest = words.Length;
        
        for(var i = 0; i < words.Length; i++) {
            var word = words[i];
            
            if (word.CompareTo(word1) == 0) {
                i1 = i;
                
                if (i2 > -1) {
                    shortest = Math.Min(shortest, Math.Abs(i1 - i2));
                }
            }
            else if (word.CompareTo(word2) == 0) {
                i2 = i;
                
                if (i1 > -1) {
                    shortest = Math.Min(shortest, Math.Abs(i1 - i2));
                }
            }
        }
        
        return shortest;
    }
}