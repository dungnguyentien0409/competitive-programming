/**
 * Link: https://leetcode.com/problems/diameter-of-binary-tree/
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
    public int DiameterOfBinaryTree(TreeNode root) {
        if (root == null) return 0;
        
        Max = Int32.MinValue;
        
        PostOrder(root);
        
        return Max - 1;
    }
    
    int Max;
    
    public int PostOrder(TreeNode node) {
        if (node == null) return 0;
        
        var left = PostOrder(node.left);
        var right = PostOrder(node.right);
        
        Max = Math.Max(Max, left + right + 1);
        
        return 1 + Math.Max(left, right);
    }
}