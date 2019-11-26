/**
 * Problem: https://leetcode.com/problems/find-bottom-left-tree-value/
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
    public int FindBottomLeftValue(TreeNode root) {
        var queue = new Queue();
        var leftMost = new TreeNode(root.val);
        queue.Enqueue(root);
        
        while(queue.Count > 0) {
            var length = queue.Count;
            var assigned = false;
            
            for (var i = 0; i < length; i++) {
                var node = (TreeNode)queue.Dequeue();    
                
                if (node.left == null && node.right == null) {
                    if (!assigned) {
                        leftMost = node;
                        assigned = true;
                    }
                }
                if (node.left != null) queue.Enqueue(node.left);
                if (node.right != null) queue.Enqueue(node.right);
            }
        }
        
        return leftMost.val;
    }
}