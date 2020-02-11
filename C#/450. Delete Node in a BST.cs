/**
 * Link: https://leetcode.com/problems/delete-node-in-a-bst/submissions/
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
    public TreeNode DeleteNode(TreeNode root, int key) {
        if (root == null) return root;
        
        else if (root.val > key) root.left = DeleteNode(root.left, key);
        else if (root.val < key) root.right = DeleteNode(root.right, key);
        else {
            if (root.left == null) {
                return root.right;
            }
            else if (root.right == null) {
                return root.left;
            }
            else {
                var min = FindReplace(root.right);
                
                root.val = min.val;
                root.right = DeleteNode(root.right, min.val);
            }
        }
        
        return root;
    }
    
    public TreeNode FindReplace(TreeNode node) {
        if (node.left == null) return node;
        
        return FindReplace(node.left);
    }
}