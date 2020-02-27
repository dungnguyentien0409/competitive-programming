/**
 * Link: https://leetcode.com/problems/deepest-leaves-sum/submissions/
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
    public int DeepestLeavesSum(TreeNode root) {
        var queue = new Queue<TreeNode>();
        int sum = 0;
        
        queue.Enqueue(root);
        while(queue.Count > 0) {
            var len = queue.Count;
            sum = 0;
            
            for (var i = 0; i < len; i++) {
                var n = queue.Dequeue();
                
                sum += n.val;
                if (n.left != null) queue.Enqueue(n.left);
                if (n.right != null) queue.Enqueue(n.right);
            }
        }
        
        return sum;
    }
}