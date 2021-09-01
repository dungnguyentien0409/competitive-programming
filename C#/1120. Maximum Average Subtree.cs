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
    double max;
    public double MaximumAverageSubtree(TreeNode root) {
        max = 0;
        Average(root);
        
        return max;
    }
    
    public (double, int) Average(TreeNode node) {
        if (node == null) return (0, 0);
        
        var left = Average(node.left);
        var right = Average(node.right);
        
        var val = left.Item1 + right.Item1 + node.val;
        var total = left.Item2 + right.Item2 + 1;
        var average = val * 1.0 / total;
        
        max = Math.Max(max, average);
        
        return (val, total);
    }
}