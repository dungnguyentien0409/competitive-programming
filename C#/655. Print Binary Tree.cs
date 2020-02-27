/**
 * Link: https://leetcode.com/problems/print-binary-tree/
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
    public IList<IList<string>> PrintTree(TreeNode root) {
        int rows = root == null ? 1 : GetHeight(root);
        int cols = (int)Math.Pow(2, rows) - 1;
        var result = CreateResult(rows, cols);
        
        GenerateResult(root, result, 0, rows, 0, cols - 1);
        
        return result;
    }
    
    public void GenerateResult(TreeNode node, List<IList<string>> result, int r, int rows, int c, int cols) {
        if (r == rows || node == null) return;
        
        int pos = (c + cols) / 2;
        result[r][pos] = node.val.ToString();
        GenerateResult(node.left, result, r + 1, rows, c, pos - 1);
        GenerateResult(node.right, result, r + 1, rows, pos + 1, cols);
    }
    
    public int GetHeight(TreeNode node) {
        if (node == null) return 0;
        
        return 1 + Math.Max(GetHeight(node.left), GetHeight(node.right));
    }
    
    public List<IList<string>> CreateResult(int rows, int cols) {
        var result = new List<IList<string>>();
        var r = new List<string>();
        
        for (var i = 0; i < cols; i++) {
            r.Add("");
        }
        
        for (var i = 0; i < rows; i++) {
            result.Add(new List<string>(r));    
        }
        
        return result;
    }
}