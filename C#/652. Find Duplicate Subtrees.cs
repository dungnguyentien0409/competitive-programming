/**
 * Link: https://leetcode.com/problems/find-duplicate-subtrees/
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
    public IList<TreeNode> FindDuplicateSubtrees(TreeNode root) {
        var res = new List<TreeNode>();
        
        DestructTree(root, new Dictionary<string, int>(), res);
        
        return res;
    }
    
    public string DestructTree(TreeNode node, Dictionary<string, int> map, List<TreeNode>result) {
        if (node == null) return "#";
        
        string serial = node.val + "," 
                        + DestructTree(node.left, map, result) + "," 
                        + DestructTree(node.right, map, result);
        
        if (!map.ContainsKey(serial)) map.Add(serial, 0);
        
        if (map.ContainsKey(serial) && map[serial] == 1) result.Add(node);
        map[serial]++;
        
        return serial;
    }
}