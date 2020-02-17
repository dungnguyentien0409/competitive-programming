/**
 * Link: https://leetcode.com/problems/split-bst/submissions/
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
    public TreeNode[] SplitBST(TreeNode root, int V) {
        if (root == null) return new TreeNode[] { null, null };
        
        TreeNode[] splitted;
        // SplitBST always return an array of 2 items
        // first is less than or equal
        // second is bigger
        if (root.val <= V) {
            // root is smaller or equal, find in the root.right
            // root belong to the smaller one
            splitted = SplitBST(root.right, V);
            root.right = splitted[0];
            splitted[0] = root;
        }
        else {
            // root is bigger, find in the root.left
            // root belong to the bigger one
            splitted = SplitBST(root.left, V);
            root.left = splitted[1];
            splitted[1] = root;
        }
        
        return splitted;
    }
}