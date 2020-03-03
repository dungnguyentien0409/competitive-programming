/**
 * Link: https://leetcode.com/problems/delete-nodes-and-return-forest/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * Idea: lee215
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    HashSet<int> to_delete_set;
    List<TreeNode> res;
    
    public IList<TreeNode> DelNodes(TreeNode root, int[] to_delete) {
        to_delete_set = new HashSet<int>();
        res = new List<TreeNode>();
        
        foreach (var n in to_delete) to_delete_set.Add(n);
        
        helper(root, true);
        
        return res;
    }
    
    public TreeNode helper(TreeNode node, bool isRoot) {
        if (node == null) return null;
        
        var deleted = to_delete_set.Contains(node.val);
        if (isRoot && !deleted) res.Add(node);
        
        node.left = helper(node.left, deleted);
        node.right = helper(node.right, deleted);
        
        return deleted ? null : node;
    }
}