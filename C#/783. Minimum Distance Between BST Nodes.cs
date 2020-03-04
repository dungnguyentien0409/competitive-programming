/**
 * Link: https://leetcode.com/problems/minimum-distance-between-bst-nodes/submissions/
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
    // BST so use inorder traversal left - node -right
    // can go follow the increasing order
    public int MinDiffInBST(TreeNode root) {
        pre = null;
        min = Int32.MaxValue;
        
        InorderTraversal(root);
        
        return min;
    }
    
    TreeNode pre;
    int min;
    public void InorderTraversal(TreeNode node) {
        if (node == null) return;
        InorderTraversal(node.left);
        if (pre != null) min = Math.Min(min, node.val - pre.val);
        pre = node;
        InorderTraversal(node.right);
    }
}