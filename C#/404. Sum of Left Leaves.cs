/**
 * Link: https://leetcode.com/problems/sum-of-left-leaves/
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
    public int SumOfLeftLeaves(TreeNode root) {
        if (root == null) return 0;
        
        var queue = new Queue<TreeNode>();
        var sum = 0;
        
        queue.Enqueue(root);
        while(queue.Count > 0) {
            var len = queue.Count;
            
            for (var i = 0; i < len; i++) {
                var n = queue.Dequeue();
                
                if (IsLeaf(n.left)) {
                    Console.WriteLine(n.left.val);
                    sum += n.left.val;
                }
                
                if (n.left != null) {
                    queue.Enqueue(n.left);
                }
                if (n.right != null) {
                    queue.Enqueue(n.right);
                }
            }
        }
        
        return sum;
    }
    
    public bool IsLeaf(TreeNode node) {
        if (node == null) return false;
        
        return node.left == null && node.right == null;
    }
}