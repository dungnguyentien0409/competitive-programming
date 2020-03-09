/**
 * Link: https://leetcode.com/problems/binary-tree-coloring-game/
 * Author: Dung Nguyen Tien
 * Reference: mudin
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public bool BtreeGameWinningMove(TreeNode root, int n, int x) {
        leftCount = 0; 
        rightCount = 0;
        
        Count(root, x);
        
        // if player 1 pick itself and all of its children
        if (leftCount + rightCount + 1 <= n / 2) return true;
        
        // if player 1 pick itself and its left or right
        if (leftCount > n / 2 || rightCount > n / 2) return true;
        
        return false;
    }
    
    int leftCount, rightCount;
    public int Count(TreeNode node, int x) {
        if (node == null) return 0;
        
        var left = Count(node.left, x);
        var right = Count(node.right, x);
        
        if (node.val == x) {
            leftCount = left;
            rightCount = right;
        }
        
        return left + right + 1;
    }
}