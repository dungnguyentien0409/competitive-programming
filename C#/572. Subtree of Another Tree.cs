/**
 * Link: https://leetcode.com/problems/subtree-of-another-tree/submissions/
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
    public bool IsSubtree(TreeNode s, TreeNode t) {
        // preorder traversal
        if (s == null) {
            if (t == null) return true;
            else return false;
        } 
        
        if (s.val == t.val && Compare(s, t)) {
            return true;
        }
        
        var left = IsSubtree(s.left, t);
        var right = IsSubtree(s.right, t);
        
        return left || right;
    }
    
    public bool Compare(TreeNode n1, TreeNode n2) {
        if (n1 == null && n2 == null) return true;
        else {
            if ((n1 == null || n2 == null)
                || n1.val != n2.val) return false;
            
            var left = Compare(n1.left, n2.left);
            var right = Compare(n1.right, n2.right);
            
            return left && right;
        }
    }
}