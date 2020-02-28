/**
 * Link: https://leetcode.com/problems/construct-string-from-binary-tree/submissions/
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
    public string Tree2str(TreeNode t) {
        var res = Generate(t);
        
        return res;
    }
    
    public string Generate(TreeNode t) {
        if (t == null) return "";
        
        var res = t.val.ToString();
        
        if (t.left == null && t.right == null) return res;
        else if (t.right == null) {
            res = res
                + "(" + Generate(t.left) + ")";
        }
        else {
            res = res
                + "(" + Generate(t.left) + ")"
                + "(" + Generate(t.right) + ")";
        }
        
        return res;
    }
}