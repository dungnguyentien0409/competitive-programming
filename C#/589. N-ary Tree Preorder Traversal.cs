/*
 * Link: https://leetcode.com/problems/n-ary-tree-preorder-traversal/
 * Author: Dung Nguyen Tien (Chris)
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val,IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    public IList<int> Preorder(Node root) {
        var res = new List<int>();
        
        Preorder(root, res);
        
        return res;
    }
    
    public void Preorder(Node n, List<int> res) {
        if (n == null) return;
        
        res.Add(n.val);
        foreach(var child in n.children) {
            Preorder(child, res);
        }
    }
}