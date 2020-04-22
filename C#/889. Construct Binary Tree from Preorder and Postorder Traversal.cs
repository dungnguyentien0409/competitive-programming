/**
 * Link: https://leetcode.com/problems/construct-binary-tree-from-preorder-and-postorder-traversal/
 * Author: Dung Nguyen Tien (Chris)
 * Idea by: Lee215
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    int preIndex = 0, postIndex = 0;
    
    public TreeNode ConstructFromPrePost(int[] pre, int[] post) {
        var node = new TreeNode(pre[preIndex++]);
        
        if (node.val != post[postIndex]) {
            node.left = ConstructFromPrePost(pre, post);
        }
        if (node.val != post[postIndex]) {
            node.right = ConstructFromPrePost(pre, post);
        }
        
        postIndex++;
        
        return node;
    }
}