/*
 * Link: https://leetcode.com/problems/stream-of-characters/
 * Author: Dung Nguyen Tien (Chris)
*/

public class StreamChecker {
    TrieNode root;
    StringBuilder current;
    
    public StreamChecker(string[] words) {
        root = new TrieNode();
        current = new StringBuilder();
        
        foreach(var w in words) {
            Insert(w);
        }
    }
    
    public bool Query(char letter) {
        var node = root;
        current.Append(letter);
        
        for (var i = current.Length - 1; i >= 0 && node != null; i--) {
            var c = current[i];
            node = node.child[c - 'a'];
            
            if (node != null && node.hasWord) {
                return true;
            }
        }
        
        return false;
    }
    
    public void Insert(string word) {
        var node = root;
        var arr = word.ToCharArray();
        
        Array.Reverse(arr);
        word = new string(arr);
        
        foreach(var c in word) {
            if (node.child[c - 'a'] == null) {
                node.child[c - 'a'] = new TrieNode();
            }
            
            node = node.child[c - 'a'];
        }
        
        node.hasWord = true;
    }
}

public class TrieNode {
    public TrieNode[] child;
    public bool hasWord;
    
    public TrieNode() {
        child = new TrieNode[26];
        hasWord = false;
    }
}
/**
 * Your StreamChecker object will be instantiated and called as such:
 * StreamChecker obj = new StreamChecker(words);
 * bool param_1 = obj.Query(letter);
 */