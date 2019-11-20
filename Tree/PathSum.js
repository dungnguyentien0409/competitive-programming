/**
 * Problem: https://leetcode.com/problems/path-sum/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * Definition for a binary tree node.
 * function TreeNode(val) {
 *     this.val = val;
 *     this.left = this.right = null;
 * }
 */
/**
 * @param {TreeNode} root
 * @param {number} sum
 * @return {boolean}
 */
var hasPathSum = function(root, sum) {
    if (root == null) return false;
    
    return goSum(root, 0, sum);
};

function goSum(node, current, sum) {
    if (node == null) return false;
    
    current += node.val;
    
    if (current == sum && isLeaf(node)) return true; 
    
    return goSum(node.left, current, sum) || goSum(node.right, current, sum);
}

function isLeaf(node) {
    return node.left == null && node.right == null;
}