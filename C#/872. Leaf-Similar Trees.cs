/**
 * Link: https://leetcode.com/problems/leaf-similar-trees/
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
    public bool LeafSimilar(TreeNode root1, TreeNode root2) {
        var leaf1 = GetLeaf(root1);
        var leaf2 = GetLeaf(root2);
        
        return leaf1 == leaf2;
    }
    
    public string GetLeaf(TreeNode node) {
        if (node == null) return "";
        
        if (node.left == null && node.right == null) return node.val.ToString();
        
        return GetLeaf(node.left) + GetLeaf(node.right);
    }
}