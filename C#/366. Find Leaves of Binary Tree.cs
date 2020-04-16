/**
 * Link: https://leetcode.com/problems/find-leaves-of-binary-tree/
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
    public IList<IList<int>> FindLeaves(TreeNode root) {
        var height = GetHeight(root);
        var result = CreateResult(height);
        
        Traversal(root, result);
        
        return result;
    }
    
    public int Traversal(TreeNode node, List<IList<int>> result) {
        if (node == null) return -1;
        
        var leftLevel = Traversal(node.left, result);
        var rightLevel = Traversal(node.right, result);
        var level = Math.Max(leftLevel, rightLevel) + 1;
        
        result[level].Add(node.val);
        
        return level;
    }
    
    public List<IList<int>> CreateResult(int minHeight) {
        var res = new List<IList<int>>();
        
        for (var i = 0; i < minHeight; i++) {
            res.Add(new List<int>());
        }
        
        return res;
    }
    
    public int GetHeight(TreeNode node) {
        if (node == null) return 0;
        
        return 1 + Math.Max(GetHeight(node.left), GetHeight(node.right));
    }
}