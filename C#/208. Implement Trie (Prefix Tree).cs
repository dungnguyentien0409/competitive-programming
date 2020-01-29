/*
 * Link: https://leetcode.com/problems/implement-trie-prefix-tree/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Trie {
    
    TrieNode root;
    
    /** Initialize your data structure here. */
    public Trie() {
        root = new TrieNode();    
    }
    
    /** Inserts a word into the trie. */
    public void Insert(string word) {
        Find(word, true);
    }
    
    /** Returns if the word is in the trie. */
    public bool Search(string word) {
        var node = Find(word, false);
        
        return node != null && node.hasWord;
    }
    
    /** Returns if there is any word in the trie that starts with the given prefix. */
    public bool StartsWith(string prefix) {
        var node = Find(prefix, false);
        
        return node != null;
    }
    
    public TrieNode Find(string word, bool insert) {
        TrieNode node = root;
        int indexW = 0;
        
        while(node != null && indexW < word.Length) {
            int indexN = word[indexW] - 'a';
            
            if (node.nodes[indexN] == null && insert) {
                node.nodes[indexN] = new TrieNode();
            }
            
            node = node.nodes[indexN];
            indexW++;
        }
        
        if (insert) node.hasWord = true;
        return node;
    }
}

public class TrieNode {
    public bool hasWord;
    public TrieNode[] nodes = new TrieNode[26];
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */