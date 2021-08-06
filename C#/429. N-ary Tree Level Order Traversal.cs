/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    public IList<IList<int>> LevelOrder(Node root) {
        var q = new Queue<Node>();
        var res = new List<IList<int>>();
        
        if (root == null) return res;
        
        q.Enqueue(root);
        while(q.Count > 0) {
            var len = q.Count;
            var cur = new List<int>();
            
            for (var i = 0; i < len; i++) {
                var n = q.Dequeue();
                cur.Add(n.val);
                
                if (n.children.Count > 0) {
                    foreach(var c in n.children) q.Enqueue(c);
                }
            }
            
            res.Add(cur);
        }
        
        return res;
    }
}