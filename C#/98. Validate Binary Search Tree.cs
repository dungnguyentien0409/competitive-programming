/**
 * Link: https://leetcode.com/problems/validate-binary-search-tree/
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
    public bool IsValidBST(TreeNode root) {
        return go(root, long.MaxValue, long.MinValue);
    }
    
    public bool go(TreeNode node, long max, long min) {
        if (node == null) return true;
        if (node.val >= max || node.val <= min) return false;
        
        var left = node.left;
        var right = node.right;
        
        if (left != null && left.val >= node.val) return false;
        if (right != null && right.val <= node.val) return false;
        
        return true 
               && go(left, node.val, min) 
               && go(right, max, node.val);
    }
}