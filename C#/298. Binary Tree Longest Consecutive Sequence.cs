/**
 * Link: https://leetcode.com/problems/binary-tree-longest-consecutive-sequence/
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
    public int LongestConsecutive(TreeNode root) {
        longest = 0;
        
        Traversal(root, 1);
        
        return longest;
    }
    
    int longest;
    
    public void Traversal(TreeNode node, int level) {
        if (node == null) return;
        
        longest = Math.Max(longest, level);
        
        if (node.left == null || (node.left != null && node.val + 1 != node.left.val)) {
            Traversal(node.left, 1);
        }
        else {
            Traversal(node.left, level + 1);
        }
        
        if (node.right == null
           || (node.right != null && node.val + 1 != node.right.val)) {
            Traversal(node.right, 1);
        }
        else {
            Traversal(node.right, level + 1);
        }
    }
}