/**
 * Link: https://leetcode.com/problems/inorder-successor-in-bst/
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
    public TreeNode InorderSuccessor(TreeNode root, TreeNode p) {
        if (root == null) return root;
        
        if (root.val <= p.val) {
            return InorderSuccessor(root.right, p);
        }
        else {
            var mostLeft = InorderSuccessor(root.left, p);
            if (mostLeft == null) return root;
            
            return mostLeft;
        }
    }
}