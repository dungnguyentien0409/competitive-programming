/**
 * Link: https://leetcode.com/problems/kth-smallest-element-in-a-bst/
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
    int count = 0;
    int res = 0;
    public int KthSmallest(TreeNode root, int k) {
        traversal(root, k);
        
        return res;
    }
    
    public void traversal(TreeNode node, int k) {
        if (node == null) return;
        
        traversal(node.left, k);
        count++;
        
        if (count == k) {
            res = node.val;
        }
        
        traversal(node.right, k);
    }
}