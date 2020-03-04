/**
 * Link: https://leetcode.com/problems/path-sum-ii/submissions/
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
    public IList<IList<int>> PathSum(TreeNode root, int sum) {
        IList<IList<int>> res = new List<IList<int>>();
        
        GoSum(root, 0, sum, new List<int>(), res);
        return res;
    }
    
    public void GoSum(TreeNode node, int curS, int sum, List<int> curRes, IList<IList<int>> res) {
        if (node == null) return;
        
        curS += node.val;
        curRes.Add(node.val);
        if (curS == sum && IsLeaf(node)) res.Add(new List<int>(curRes));
        
        GoSum(node.left, curS, sum, curRes, res);
        GoSum(node.right, curS, sum, curRes, res);
        
        curRes.RemoveAt(curRes.Count - 1);
    }
    
    public bool IsLeaf(TreeNode node) {
        return node.left == null && node.right == null;
    }
}