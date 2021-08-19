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
    long total, max;
    public int MaxProduct(TreeNode root) {
        total = Traversal(root);
        max = Int64.MinValue;
        
        Traversal(root);
        
        return (int)(max % (Math.Pow(10, 9) + 7));
    }
    
    public long Traversal(TreeNode node) {
        if (node == null) return 0;
        
        var left = Traversal(node.left);
        var right = Traversal(node.right);
        long res = node.val + left + right;
        
        max = Math.Max(max, res * (total - res));
        
        return res;
    }
}