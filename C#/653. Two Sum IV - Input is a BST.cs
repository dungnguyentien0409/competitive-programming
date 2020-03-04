/**
 * Link: https://leetcode.com/problems/two-sum-iv-input-is-a-bst/submissions/
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
    public bool FindTarget(TreeNode root, int k) {
        if (root == null) return false;
        
        var result = InOrder(root, k, new HashSet<int>());
        
        return result;
    }
    
    public bool InOrder(TreeNode node, int k, HashSet<int> map) {
        if (node == null) return false;
        
        var left = InOrder(node.left, k, map);
        if (left == true) return true;
        
        if (map.Contains(k - node.val)) return true;
        map.Add(node.val);
        
        var right = InOrder(node.right, k, map);
        if (right == true) return true;
        
        return false;
    }
}