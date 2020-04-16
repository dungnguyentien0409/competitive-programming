/**
 * Link: https://leetcode.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal/
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
    int[] pOrder;
    int[] iOrder;
    
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        this.pOrder = preorder;
        this.iOrder = inorder;
        
        var root = helper(0, 0, inorder.Length - 1);
        
        return root;
    }
    
    public TreeNode helper(int pStart, int iStart, int iEnd) {
        if (pStart >= pOrder.Length || iStart > iEnd) return null;
        
        var node = new TreeNode(pOrder[pStart]);
        var index = Array.IndexOf(iOrder, node.val);
        var leftIndex = pStart + 1;
        var rightIndex = pStart + 1 + (index - iStart);
        
        node.left = helper(leftIndex, iStart, index - 1);
        node.right = helper(rightIndex, index + 1, iEnd);
        
        return node;
    }
}