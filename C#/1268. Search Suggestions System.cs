/*
 * Link: https://leetcode.com/problems/search-suggestions-system/submissions/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public IList<IList<string>> SuggestedProducts(string[] products, string searchWord) {
        var root = new TrieNode();
        
        Array.Sort(products);
        foreach(var p in products) Insert(p, root);
        
        return Search(searchWord, root);
    }
    
    public void Insert(string w, TrieNode root) {
        var node = root;
        var index = 0;
        
        while(node != null && index < w.Length) {
            var c = w[index++];
            
            if (node.next[c - 'a'] == null) {
                node.next[c - 'a'] = new TrieNode();
            }
            
            node = node.next[c - 'a'];
            
            if (node.suggestions.Count < 3) {
                node.suggestions.Add(w);
            }
        }
    }
    
    public List<IList<string>> Search(string w, TrieNode root) {
        var res = new List<IList<string>>();
        var node = root;
        
        foreach(var c in w) {
            if (node != null) {
                node = node.next[c - 'a'];
            }
            
            res.Add(node != null ? node.suggestions : new List<string>());
        }
        
        return res;
    }
}

public class TrieNode {
    public TrieNode[] next;
    public List<string> suggestions;
    
    public TrieNode() {
        next = new TrieNode[26];
        suggestions = new List<string>();
    }
    
}