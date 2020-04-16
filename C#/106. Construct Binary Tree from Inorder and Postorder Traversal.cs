/**
 * Link: https://leetcode.com/problems/construct-binary-tree-from-inorder-and-postorder-traversal/
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
    int[] iOrder;
    int[] pOrder;
    
    public TreeNode BuildTree(int[] inorder, int[] postorder) {
        this.iOrder = inorder;
        this.pOrder = postorder;
        
        var root = helper(postorder.Length - 1, 0, inorder.Length - 1);
        
        return root;
    }
    
    public TreeNode helper(int pStart, int iStart, int iEnd) {
        if (pStart < 0 || iStart > iEnd) return null;
        
        var node = new TreeNode(this.pOrder[pStart]);
        var index = Array.IndexOf(this.iOrder, node.val);
        var rightIndex = pStart - 1;
        var leftIndex = pStart - 1 - (iEnd - index); // inEnd - index is the number of right elements
        
        node.right = helper(rightIndex, index + 1, iEnd);
        node.left = helper(leftIndex, iStart, index - 1);
        return node;
    }
}