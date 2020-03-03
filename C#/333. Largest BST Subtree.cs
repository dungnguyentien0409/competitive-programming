/**
 * Link: https://leetcode.com/problems/largest-bst-subtree/
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
    public int LargestBSTSubtree(TreeNode root) {
        if (root == null) return 0;
        
        var result = DFS(root);
        
        return result.count;
    }
    
    public (int count, int min, int max) DFS(TreeNode root) {
        if (root == null) return (0, Int32.MaxValue, Int32.MinValue);
        
        var left = DFS(root.left);
        var right = DFS(root.right);
        
        if (left.max < root.val && root.val < right.min) {
            // valid - increase count
            return (left.count + right.count + 1, 
                    Math.Min(root.val, left.min), 
                    Math.Max(root.val, right.max));
        }
        else {
            // not valid, pick the max count
            return (Math.Max(left.count, right.count), 
                    int.MinValue, 
                    int.MaxValue);
        }
    }
}