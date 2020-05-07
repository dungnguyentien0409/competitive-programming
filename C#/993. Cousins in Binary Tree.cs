/**
 * Link: https://leetcode.com/problems/cousins-in-binary-tree/submissions/
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
    public bool IsCousins(TreeNode root, int x, int y) {
        if (root == null) return false;
        
        var queue = new Queue<TreeNode>();
        
        queue.Enqueue(root);
        while(queue.Count > 0) {
            var count = 0;
            var len = queue.Count;
            
            for (var i = 0; i < len; i++) {
                var node = queue.Dequeue();
                
                if (node.val == x || node.val == y) {
                    count++;
                    
                    if (count == 2) return true;
                }
                
                if (node.left != null && node.right != null) {
                    int left = node.left.val, right = node.right.val;
                    
                    if ((left == x && right == y) 
                        || (left == y && right == x)) return false;
                }
                
                if (node.left != null) queue.Enqueue(node.left);
                if (node.right != null) queue.Enqueue(node.right);
            }
        }
        
        return false;
    }
}