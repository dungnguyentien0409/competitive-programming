/*
 * Link: https://leetcode.com/problems/add-and-search-word-data-structure-design/
 * Author: Dung Nguyen Tien (Chris)
*/

public class WordDictionary {
    public TrieNode root;
    
    /** Initialize your data structure here. */
    public WordDictionary() {
        root = new TrieNode();
    }
    
    /** Adds a word into the data structure. */
    public void AddWord(string word) {
        TrieNode node = root;
        
        foreach(var w in word) {
            if (node.next[w - 'a'] == null) {
                node.next[w - 'a'] = new TrieNode();
            }
            
            node = node.next[w - 'a'];
        }
        
        node.hasWord = true;
    }
    
    /** Returns if the word is in the data structure. A word could contain the dot character '.' to represent any one letter. */
    public bool Search(string word) {
        return Search(word, root, 0);
    }
    
    public bool Search(string word, TrieNode cur, int pos = 0) {
        if (pos == word.Length && cur.hasWord) return true;
        else if (pos >= word.Length) return false;
        
        var node = cur;
        if (word[pos] == '.') {
            for (var i = 0; i < node.next.Length; i++) {
                if (node.next[i] != null
                   && Search(word, node.next[i], pos + 1)) {
                    return true;
                }
            }
        }
        else {
            if (node.next[word[pos] - 'a'] != null) {
                return Search(word, node.next[word[pos] - 'a'], pos + 1);
            }
        }
        
        return false;
    }
}

public class TrieNode {
    public bool hasWord;
    public TrieNode[] next;
    
    public TrieNode() {
        hasWord = false;
        next = new TrieNode[26];
    }
}
/**
 * Your WordDictionary object will be instantiated and called as such:
 * WordDictionary obj = new WordDictionary();
 * obj.AddWord(word);
 * bool param_2 = obj.Search(word);
 */