/**
 * Link: https://leetcode.com/problems/maximum-difference-between-node-and-ancestor/
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
    public int MaxAncestorDiff(TreeNode root) {
        if (root == null) return 0;
        
        return FindMax(root, root.val, root.val);
    }
    
    public int FindMax(TreeNode node, int min, int max) {
        if (node == null) return max - min;
        
        max = Math.Max(node.val, max);
        min = Math.Min(node.val, min);
        
        return Math.Max(FindMax(node.left, min, max),
                       FindMax(node.right, min, max));
    }
}