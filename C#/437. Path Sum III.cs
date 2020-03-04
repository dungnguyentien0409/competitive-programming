/**
 * Link: https://leetcode.com/problems/path-sum-iii/submissions/
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
    public int PathSum(TreeNode root, int sum) {
        if (root == null) return 0;
        
        var res = goSum(root, 0, sum);
        
        res += PathSum(root.left, sum);
        res += PathSum(root.right, sum);
        
        return res;
    }
    
    public int goSum(TreeNode node, int curS, int sum) {
        if (node == null) return 0;
        
        curS += node.val;
        
        return (curS == sum ? 1 : 0) + goSum(node.left, curS, sum) + goSum(node.right, curS, sum);
    }
}