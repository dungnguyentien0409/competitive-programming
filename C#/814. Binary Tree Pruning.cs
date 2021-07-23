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
    public TreeNode PruneTree(TreeNode root) {
        var check = CutTree(root);
        
        return check ? root : null;
    }
    
    public bool CutTree(TreeNode node) {
        if (node == null) return false;
        
        var left = CutTree(node.left);
        var right = CutTree(node.right);
        
        if (!left) node.left = null;
        if (!right) node.right = null;
        
        return node.val == 1 || left || right;
    }
}