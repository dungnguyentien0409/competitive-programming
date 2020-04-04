/**
 * Link: https://leetcode.com/problems/vertical-order-traversal-of-a-binary-tree/
 * Author: Dung Nguyen Tien (Chris)
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public IList<IList<int>> VerticalTraversal(TreeNode root) {
        var height = GetHeight(root);
        var width = 2 * height - 1;
        var result = CreateResult(width);
        
        InOrder(root, width / 2, 0, result);
        
        result = result.Where(w => w.Count > 0).ToList();
        foreach(List<Node> l in result) {
            l.Sort(delegate(Node a, Node b) {
                if (a.y == b.y) {
                    return a.value - b.value;
                }
            
                return a.y - b.y;
            });
        }
        
        var f_result = new List<IList<int>>();
        
        foreach(var l in result) {
            IList<int> tmp = l.Select(s => s.value).ToList();
            f_result.Add(tmp);
        }
        
        return f_result;
    }
    
    public void InOrder(TreeNode node, int x, int y, List<IList<Node>> result) {
        if (node == null) return;
        
        result[x].Add(new Node(x, y, node.val));
        InOrder(node.left, x - 1, y + 1, result);
        InOrder(node.right, x + 1, y + 1, result);
    }
    
    public List<IList<Node>> CreateResult(int width) {
        var result = new List<IList<Node>>();
        
        for (var i = 0; i < width; i++) {
            result.Add(new List<Node>());
        }
        
        return result;
    }
    
    public int GetHeight(TreeNode root) {
        if (root == null) return 0;
        
        return 1 + Math.Max(GetHeight(root.left), GetHeight(root.right));
    }
}

public class Node {
    public int x;
    public int y;
    public int value;
    
    public Node(int x, int y, int v) {
        this.x = x;
        this.y = y;
        this.value = v;
    }
}