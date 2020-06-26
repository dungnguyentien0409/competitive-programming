/**
 * Link: https://leetcode.com/problems/sum-root-to-leaf-numbers/submissions/
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
    public int SumNumbers(TreeNode root) {
        if (root == null) return 0;
        
        var numbers = GetNumber(root, 0);
        var sum = 0;
        
        foreach(var n in numbers) {
            //Console.WriteLine(n);
            sum += n;
        }
        
        return sum;
    }
    
    public List<int> GetNumber(TreeNode node, int current) {
        if (node == null) return new List<int>();
        if (node.left == null && node.right == null) {
            return new List<int>(new int[] { current * 10 + node.val });
        }
        
        var left = GetNumber(node.left, current * 10 + node.val);
        var right = GetNumber(node.right, current * 10 + node.val);
        
        var res = new List<int>();
        res.AddRange(left);
        res.AddRange(right);
        
        return res;
    }
}