public class MapSum {
    Trie root;

    /** Initialize your data structure here. */
    public MapSum() {
        root = new Trie();
    }
    
    public void Insert(string key, int val) {
        Find(key, val, true);
    }
    
    public int Sum(string prefix) {
        var node = Find(prefix, 0);
        
        return BFS(node);
    }
    
    public int BFS(Trie node) {
        if (node == null) return 0;
        
        var q = new Queue<Trie>();
        int res = 0;
        
        q.Enqueue(node);
        while(q.Count > 0) {
            int len = q.Count;
            
            for(var i = 0; i < len; i++) {
                var cur = q.Dequeue();
                
                for(var j = 0; j < 26; j++) {
                    if (cur.next[j] != null) q.Enqueue(cur.next[j]);
                }
                
                if (cur.end) res += cur.val;
            }
        }
        
        return res;
    }
    
    public Trie Find(string key, int val, bool insert = false) {
        var cur = root;
        
        for(var i = 0; i < key.Length; i++) {
            var index = key[i] - 'a';
            
            if (cur.next[index] == null && insert) {
                cur.next[index] = new Trie();
            }
            cur = cur.next[index];
            if (cur == null) break;
        }
        
        if (insert) {
            cur.end = true;
            cur.val = val;
        }
        
        return cur;
    }
}


public class Trie {
    public bool end { get; set; }
    public int val { get; set; }
    public Trie[] next { get; set; }
    
    public Trie() {
        end = false;
        next = new Trie[26];
    }
}
/**
 * Your MapSum object will be instantiated and called as such:
 * MapSum obj = new MapSum();
 * obj.Insert(key,val);
 * int param_2 = obj.Sum(prefix);
 */