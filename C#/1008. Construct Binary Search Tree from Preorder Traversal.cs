/**
 * Link: https://leetcode.com/problems/construct-binary-search-tree-from-preorder-traversal/submissions/
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
    public TreeNode BstFromPreorder(int[] preorder) {
        var list = new List<int>(preorder);
        var root = helper(list, Int32.MaxValue, Int32.MinValue);
        
        return root;
    }
    
    public TreeNode helper(List<int> list, int max, int min) {
        if (list.Count == 0) return null;
        
        var val = list[0];
        
        if (val >= max || val <= min) return null;
        
        list.RemoveAt(0);
        var node = new TreeNode(val);
        node.left = helper(list, node.val, min);
        node.right = helper(list, max, node.val);
            
        return node;
    }
}