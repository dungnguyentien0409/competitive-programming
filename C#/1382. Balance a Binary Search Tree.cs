/**
 * Link: https://leetcode.com/problems/balance-a-binary-search-tree/
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
    public TreeNode BalanceBST(TreeNode root) {
        var res = new List<int>();
        Inorder(root, res);
        
        var node = BuildBalancedBST(res, 0, res.Count - 1);
        
        return node;
    }
    
    public TreeNode BuildBalancedBST(List<int> res, int left, int right) {
        if (left > right) return null;
        
        var mid = (left + right) / 2;
        var node = new TreeNode(res[mid]);
        node.left = BuildBalancedBST(res, left, mid - 1);
        node.right = BuildBalancedBST(res, mid + 1, right);
        
        return node;
    }
    
    public void Inorder(TreeNode node, List<int> res) {
        if (node == null) return;
        
        Inorder(node.left, res);
        res.Add(node.val);
        Inorder(node.right, res);
    }
}