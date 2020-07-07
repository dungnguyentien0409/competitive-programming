/*
 * Link: https://leetcode.com/problems/longest-repeating-substring/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int LongestRepeatingSubstring(string S) {
        var root = new TrieNode();
        int longest = 0;
        
        for (var i = 0; i < S.Length; i++) {
            TrieNode cur = root;
            
            for (var j = i; j < S.Length; j++) {
                if (cur.next[S[j] - 'a'] == null) {
                    cur.next[S[j] - 'a'] = new TrieNode();
                }   
                else {
                    longest = Math.Max(longest, j - i + 1);
                }
                
                cur = cur.next[S[j] - 'a'];
            }
        }
        
        return longest;
    }
}

public class TrieNode {
    public TrieNode[] next;
    
    public TrieNode() {
        next = new TrieNode[26];
    }
}