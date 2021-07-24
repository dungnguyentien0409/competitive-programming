/**
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
    public TreeNode SufficientSubset(TreeNode root, int limit) {
        return Delete(root, 0, limit);
    }
    
    public TreeNode Delete(TreeNode node, int sum, int limit) {
        if (node == null) return null;
        if (node.left == null && node.right == null) {
            if (node.val + sum < limit) return null;
            return node;
        }
        
        node.left = Delete(node.left, sum + node.val, limit);
        node.right = Delete(node.right, sum + node.val, limit);
        
        if (node.left == null && node.right == null) return null;
        return node;
    }
}