/**
 * Link: https://leetcode.com/problems/binary-tree-zigzag-level-order-traversal/
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
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        if (root == null) return new List<IList<int>>();
        
        var queue = new Queue<TreeNode>();
        var res = new List<IList<int>>();
        
        queue.Enqueue(root);
        while(queue.Count > 0) {
            var len = queue.Count;
            var current = new List<int>();
            
            for (var i = 0; i < len; i++) {
                var node = queue.Dequeue();
                
                current.Add(node.val);
                if (node.left != null) queue.Enqueue(node.left);
                if (node.right != null) queue.Enqueue(node.right);
            }
            
            if (res.Count % 2 != 0) {
                current.Reverse();
            }
            res.Add(current);
        }
        
        return res;
    }
}