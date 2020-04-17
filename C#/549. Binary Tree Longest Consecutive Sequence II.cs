/**
 * Link: https://leetcode.com/problems/binary-tree-longest-consecutive-sequence-ii/
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
        if (root == null) return 0;
        
        longest = 0;
        helper(root);
        
        return longest;
    }
    
    int longest;
    // foreach node 
    // if it is in a des path, des + 1
    // if it is in a ins path, ins + 1
    public int[] helper(TreeNode node) {
        if (node == null) return new int[2] { 0, 0 };
        
        var left = helper(node.left);
        var right = helper(node.right);
        int des = 1, ins = 1;
        
        if(node.left != null) {
            if (node.val == node.left.val + 1) {
                // current in the ins
                ins = left[1] + 1;
            }
            if (node.val == node.left.val - 1) {
                // current in the des
                des = left[0] + 1;
            }
        }
        if (node.right != null) {
            if (node.val == node.right.val - 1) {
                // current in the des
                des = Math.Max(des, right[0] + 1);
            } 
            if (node.val == node.right.val + 1) {
                // current in the ins
                ins = Math.Max(ins, right[1] + 1);
            }
        }
        
        longest = Math.Max(longest, des + ins - 1);
        
        return new int[2] { des, ins };
    }
}