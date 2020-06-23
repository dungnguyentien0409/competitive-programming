/**
 * Link: https://leetcode.com/problems/count-complete-tree-nodes/
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
    public int CountNodes(TreeNode root) {
        if (root == null) return 0;
        
        var left = LeftHeight(root);
        var right = RightHeight(root);
        
        if (left == right) {
            return (int)Math.Pow(2, left) - 1;
        }
        
        return 1 + CountNodes(root.left) + CountNodes(root.right);
    }
    
    public int LeftHeight(TreeNode node) {
        if (node == null) return 0;
        
        return 1 + LeftHeight(node.left);
    }
    
    public int RightHeight(TreeNode node) {
        if (node == null) return 0;
        
        return 1 + RightHeight(node.right);
    }
}