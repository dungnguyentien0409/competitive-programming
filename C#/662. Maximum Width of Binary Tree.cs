/**
 * Link: https://leetcode.com/problems/maximum-width-of-binary-tree/
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
    public int WidthOfBinaryTree(TreeNode root) {
        var queue = new Queue<Node>();
        var maxW = 0;
        
        queue.Enqueue(new Node(root, 0));
        while(queue.Count > 0) {
            var len = queue.Count;
            
            int start = 0, end = 0;
            for (var i = 0; i < len; i++) {
                var pop = queue.Dequeue();
                var node = pop.n;
                var index = pop.index;
                
                if (i == 0) start = index;
                if (i == len - 1) end = index;
                
                if (node.left != null) {
                    queue.Enqueue(new Node(node.left, 2 * index + 1));
                }
                
                if (node.right != null) {
                    queue.Enqueue(new Node(node.right, 2 * index + 2));
                }
            }
            Console.WriteLine(start + "..." + end);
            maxW = Math.Max(maxW, end - start + 1);
        }
        
        return maxW;
    }
}

public class Node {
    public TreeNode n;
    public int index;
    
    public Node(TreeNode n1, int i) {
        n = n1;
        index = i;
    }
}