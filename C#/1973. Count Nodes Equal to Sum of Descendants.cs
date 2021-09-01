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
    public int EqualToDescendants(TreeNode root) {
        var res = Count(root);
        
        return res.Item2;
    }
    
    public (int, int) Count(TreeNode node) {
        if (node == null) return (0, 0);
        
        var left = Count(node.left);
        var right = Count(node.right);
        int count = left.Item2 + right.Item2;
        
        if(left.Item1 + right.Item1 == node.val) {
            count++;
        }
        
        return (left.Item1 + right.Item1 + node.val, count);
    }
}