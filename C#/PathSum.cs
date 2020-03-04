/**
 * Problem: https://leetcode.com/problems/path-sum/submissions/
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
    public bool HasPathSum(TreeNode root, int sum) {
        return GoSum(root, 0, sum);
    }
    
    public bool GoSum(TreeNode node, int curS, int sum) {
        if (node == null) return false;
        
        curS += node.val;
        if (curS == sum && IsLeaf(node)) return true;
        
        return GoSum(node.left, curS, sum) || GoSum(node.right, curS, sum);
    }
    
    public bool IsLeaf(TreeNode node) {
        return node.left == null && node.right == null;
    }
}