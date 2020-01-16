/**
 * Link: https://leetcode.com/problems/boundary-of-binary-tree/
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
    public IList<int> BoundaryOfBinaryTree(TreeNode root) {
        var res = new List<int>();
        
        if(root == null) return res;
        
        res.Add(root.val);
        Left(root.left, res);
        Leaf(root.left, res);
        Leaf(root.right, res);
        Right(root.right, res);

        return res;
    }
    
    public void Left(TreeNode node, List<int> res) {
        if(node == null || IsLeaf(node)) return;
        
        res.Add(node.val);
        if(node.left == null) Left(node.right, res);
        else Left(node.left, res);
    }
    
    public void Right(TreeNode node, List<int> res) {
        if(node == null || IsLeaf(node)) return;
        
        if(node.right == null) Right(node.left, res);
        else Right(node.right, res);
        
        res.Add(node.val);
    }
    
    public void Leaf(TreeNode node, List<int> res) {
        if(node == null) return;
        if(node.left == null && node.right == null) {
            res.Add(node.val);
            return;
        }
        
        Leaf(node.left, res);
        Leaf(node.right, res);
    }
    
    public bool IsLeaf(TreeNode node) {
        if (node == null) return true;
        
        return node.left == null && node.right == null;
    }
}