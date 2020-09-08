/**
 * Link: https://leetcode.com/problems/sum-of-root-to-leaf-binary-numbers/
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
    public int SumRootToLeaf(TreeNode root) {
        return dfs(root, 0);
    }
    
    public int dfs(TreeNode node, int current) {
        if (node == null) return 0;
        
        var sum = current * 2 + node.val;
        
        return (node.left == null && node.right == null) ? 
            sum : dfs(node.left, sum) + dfs(node.right, sum);
    }
}