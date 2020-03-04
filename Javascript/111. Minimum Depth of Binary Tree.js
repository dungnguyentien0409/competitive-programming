/**
 * Link: https://leetcode.com/problems/minimum-depth-of-binary-tree/
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
var minDepth = function(root) {
    var min = goDown(root, 1);
    
    return min == Number.MAX_SAFE_INTEGER ? 0 : min;
};

function goDown(root, count) {
    if (root == null) return Number.MAX_SAFE_INTEGER;
    if (root.left == null && root.right == null) return count;
    
    var left = goDown(root.left, count + 1);
    var right = goDown(root.right, count + 1);
    
    return Math.min(left, right);
}