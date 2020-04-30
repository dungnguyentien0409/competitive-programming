/**
 * Link: https://leetcode.com/problems/binary-tree-maximum-path-sum/
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
    public int MaxPathSum(TreeNode root) {
        f_max = Int32.MinValue;
        
        GoSum(root);
        
        return f_max;
    }
    
    int f_max;
    public int GoSum(TreeNode node) {
        if (node == null) return 0;
        
        var left = Math.Max(0, GoSum(node.left));
        var right = Math.Max(0, GoSum(node.right));
        
        f_max = Math.Max(f_max, node.val + left + right);

        return Math.Max(left, right) + node.val;
    }
}