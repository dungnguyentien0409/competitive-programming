/**
 * Link: https://leetcode.com/problems/maximum-depth-of-binary-tree/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * Definition for a binary tree node.
 * function TreeNode(val) {
 *     this.val = val;
 *     this.left = this.right = null;
 * }
 */
/**
 * @param {TreeNode} root
 * @return {number}
 */
var maxDepth = function(root) {
    return countHeight(root);
};

function countHeight(root) {
    // if root is null return 0
    if (root == null) return 0;
    
    //consider this root is 1, do recurse to calculate the left and right, return the max height
    return Math.max(1 + countHeight(root.left), 1 + countHeight(root.right));
}
