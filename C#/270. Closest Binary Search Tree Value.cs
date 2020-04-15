/**
 * Link: https://leetcode.com/problems/closest-binary-search-tree-value/
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
    public int ClosestValue(TreeNode root, double target) {
        closest = root.val;
        
        traversal(root, target);
        
        return closest;
    }
    
    int closest;
    
    public void traversal(TreeNode node, double target) {
        if (node == null) return;
        
        if (Math.Abs((double)node.val - target) < Math.Abs((double)closest - target)) {
            closest = node.val;
        }
        
        if (node.val > target) traversal(node.left, target);
        else traversal(node.right, target);
    }
}