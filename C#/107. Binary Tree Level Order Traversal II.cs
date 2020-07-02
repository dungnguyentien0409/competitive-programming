/**
 * Link: https://leetcode.com/problems/binary-tree-level-order-traversal-ii/solution/
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
    public IList<IList<int>> LevelOrderBottom(TreeNode root) {
        if (root == null) return new List<IList<int>>();
        
        var st = new Stack<IList<int>>();
        var queue = new Queue<TreeNode>();
        
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
            
            st.Push(current);
        }
        
        return st.ToList();
    }
}