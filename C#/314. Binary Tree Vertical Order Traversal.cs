/**
 * Link: https://leetcode.com/problems/binary-tree-vertical-order-traversal/
 * Author: Dung Nguyen Tien (Chris)
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public IList<IList<int>> VerticalOrder(TreeNode root) {
        if (root == null) return new List<IList<int>>();
        
        var res = GenerateTemplate(root);
        var mid = res.Count / 2;
        
        VerticalTraversal(root, res, mid);
        res = res.Where(s => s.Count > 0).ToList();
        
        return res;
    }
    
    public void VerticalTraversal(TreeNode root, List<IList<int>> res, int pos) {
        var queue = new Queue<Node>();
        
        queue.Enqueue(new Node(pos, root));
        while(queue.Count > 0) {
            var len = queue.Count;
            
            for (var i = 0; i < len; i++) {
                var node = queue.Dequeue();
                
                res[node.pos].Add(node.node.val);
                
                if (node.node.left != null) queue.Enqueue(new Node(node.pos - 1, node.node.left));
                if (node.node.right != null) queue.Enqueue(new Node(node.pos + 1, node.node.right));
            }
        }
    }
    
    public List<IList<int>> GenerateTemplate(TreeNode root) {
        var height = GetHeight(root);
        var width = Math.Pow(2, height - 1) + 1;
        var res = new List<IList<int>>();
        
        for (var i = 0; i < width; i++) {
            res.Add(new List<int>());
        }
        
        return res;
    }
    
    public int GetHeight(TreeNode root) {
        if (root == null) return 0;
        
        return 1 + Math.Max(GetHeight(root.left), GetHeight(root.right));
    }
}

public class Node{
    public int pos;
    public TreeNode node;
    
    public Node(int p, TreeNode n) {
        pos = p;
        node = n;
    }
}