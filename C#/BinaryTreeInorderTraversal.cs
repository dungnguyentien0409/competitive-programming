/**
 * Problem: https://leetcode.com/problems/binary-tree-inorder-traversal/
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
    public IList<int> InorderTraversal(TreeNode root) {
        var res = new List<int>();
        
        InorderTraversal(root, ref res);
        return res;
    }
    
    public void InorderTraversal(TreeNode node, ref List<int> res) {
        if (node == null) return;
        
        InorderTraversal(node.left, ref res);
        res.Add(node.val);
        InorderTraversal(node.right, ref res);
    }
}