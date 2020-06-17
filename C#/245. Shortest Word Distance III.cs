/*
 * Link: https://leetcode.com/problems/shortest-word-distance-iii/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int ShortestWordDistance(string[] words, string word1, string word2) {
        var index = -1;
        var shortest = words.Length;
        
        for (var i = 0; i < words.Length; i++) {
            var word = words[i];
            
            if (word.CompareTo(word1) == 0 || word.CompareTo(word2) == 0) {
                if (index != -1 && (word1.CompareTo(word2) == 0 || words[index].CompareTo(words[i]) != 0)) {
                    shortest = Math.Min(shortest, i - index);
                }
                
                index = i;
            }
        }
        
        return shortest;
    }
}