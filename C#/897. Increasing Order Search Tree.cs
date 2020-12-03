/**
 * Link: https://leetcode.com/problems/increasing-order-search-tree/solution/
 * Author: Dung Nguyen Tien (Chris)
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public TreeNode IncreasingBST(TreeNode root) {
        var list = new List<int>();
        var res = new TreeNode(-1);
        
        Inorder(root, list);
        
        var current = res;
        foreach(var val in list) {
            current.right = new TreeNode(val);
            current = current.right;
        }
        
        return res.right;
    }
    
    public void Inorder(TreeNode node, List<int> list) {
        if (node == null) return;
        
        Inorder(node.left, list);
        list.Add(node.val);
        Inorder(node.right, list);
    }
}