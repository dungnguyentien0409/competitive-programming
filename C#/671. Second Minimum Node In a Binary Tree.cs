/**
 * Link: https://leetcode.com/problems/second-minimum-node-in-a-binary-tree/
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
    public int FindSecondMinimumValue(TreeNode root) {
        if (root == null) return -1;
        
        return secondMinimumValue(root, root.val);
    }
    
    public int secondMinimumValue(TreeNode node, int min) {
        if (node == null) return -1;
        
        if (node.val > min) return node.val;
        
        var left = secondMinimumValue(node.left, min);
        var right = secondMinimumValue(node.right, min);
        
        return (left != -1 && right != -1) ? Math.Min(left, right) : Math.Max(left, right);
    }
}