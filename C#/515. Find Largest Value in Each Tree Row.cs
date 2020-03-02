/**
 * Link: https://leetcode.com/problems/find-largest-value-in-each-tree-row/submissions/
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
    public IList<int> LargestValues(TreeNode root) {
        if (root == null) return new List<int>();
        
        var queue = new Queue<TreeNode>();
        var result = new List<int>();
        
        queue.Enqueue(root);
        while(queue.Count > 0) {
            var len = queue.Count;
            var max = Int32.MinValue;
            
            for (var i = 0; i < len; i++) {
                var node = queue.Dequeue();
                max = Math.Max(max, node.val);
                
                if (node.left != null) queue.Enqueue(node.left);
                if (node.right != null) queue.Enqueue(node.right);
            }
            
            result.Add(max);
        }
        
        return result;
    }
}