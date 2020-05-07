/**
 * Link: https://leetcode.com/problems/flatten-binary-tree-to-linked-list/submissions/
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
    TreeNode prev;
    public void Flatten(TreeNode root) {
        if (root == null) return;
        
        Flatten(root.right);
        Flatten(root.left);
        
        root.right = prev;
        root.left = null;
        prev = root;
    }
}