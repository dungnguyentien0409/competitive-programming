/**
 * Link: https://leetcode.com/problems/lowest-common-ancestor-of-deepest-leaves/
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
    public TreeNode LcaDeepestLeaves(TreeNode root) {
        if (root == null) return root;
        
        var left = GetHeight(root.left);
        var right = GetHeight(root.right);
        
        if (left == right) return root;
        else if (left > right) {
            return LcaDeepestLeaves(root.left);
        }
        return LcaDeepestLeaves(root.right);
    }
    
    public int GetHeight(TreeNode node) {
        if (node == null) return 0;
        
        return 1 + Math.Max(GetHeight(node.left), GetHeight(node.right));
    }
}