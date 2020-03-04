/**
 * Link: https://leetcode.com/problems/symmetric-tree/
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
    public bool IsSymmetric(TreeNode root) {
        if (root == null) return true;
        
        return Compare(root.left, root.right);
    }
    
    public bool Compare(TreeNode left, TreeNode right) {
        if (left == null && right == null) return true;
        else if ((left != null && right == null)
                || (left == null && right != null)
                || left.val != right.val) return false;
        
        return Compare(left.left, right.right) && Compare(left.right, right.left);
    }
}