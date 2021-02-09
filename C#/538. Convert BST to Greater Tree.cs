/**
 * Link: https://leetcode.com/problems/convert-bst-to-greater-tree/
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
    public TreeNode ConvertBST(TreeNode root) {
        dfs(root, 0);
        return root;
    }
    
    public int dfs(TreeNode node, int val) {
        if (node == null) return val;
        
        int right = dfs(node.right, val);
        int left = dfs(node.left, node.val + right);
        node.val = node.val + right;
        
        return left;
    }
}
