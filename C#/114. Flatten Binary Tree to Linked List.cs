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
    public void Flatten(TreeNode root) {
        TreeNode current = root;
        
        while(current != null) {
            if (current.left != null) {
                var prev = current.left;
                
                while(prev.right != null) {
                    prev = prev.right;
                }
                
                prev.right = current.right;
                current.right = current.left;
                current.left = null;
            }
            
            current = current.right;
        }
    }
}