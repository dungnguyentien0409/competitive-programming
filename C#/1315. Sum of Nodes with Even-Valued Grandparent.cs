/**
 * Link: https://leetcode.com/problems/sum-of-nodes-with-even-valued-grandparent/
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
    public int SumEvenGrandparent(TreeNode root) {
        if (root == null) return 0;
        
        return Helper(root, 1, 1);
    }
    
    public int Helper(TreeNode node, int parent, int grandparent) {
        if (node == null) return 0;
        
        return Helper(node.left, node.val, parent)
            + Helper(node.right, node.val, parent)
            + (grandparent % 2 == 0 ? node.val : 0);
    }
}