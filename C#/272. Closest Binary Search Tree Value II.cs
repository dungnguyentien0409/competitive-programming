/**
 * Link: https://leetcode.com/problems/closest-binary-search-tree-value-ii/
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
    public IList<int> ClosestKValues(TreeNode root, double target, int k) {
        var vals = new List<int>();
        
        InOrder(root, vals);
        
        while(vals.Count > k) {
            var first = vals[0];
            var last = vals[vals.Count - 1];
            
            if (GetDistance(first, target) < GetDistance(last, target)) {
                vals.RemoveAt(vals.Count - 1);
            }
            else {
                vals.RemoveAt(0);
            }
        }
        
        return vals;
    }
    
    public void InOrder(TreeNode node, List<int> vals) {
        if (node == null) return;
        
        InOrder(node.left, vals);
        vals.Add(node.val);
        InOrder(node.right, vals);
    }
    
    public double GetDistance(int val, double target) {
        return Math.Abs((double)val - target);
    }
}