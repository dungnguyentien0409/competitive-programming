/**
 * Problem: https://leetcode.com/problems/binary-tree-maximum-path-sum/
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
var maxPathSum = function(root) {
    max = Number.MIN_SAFE_INTEGER;
    var sum = goSum(root);
    
    return max;
};

var max;
function goSum(root) {
    if (root == null) return Number.MIN_SAFE_INTEGER;
    
    var left = goSum(root.left);
    var right = goSum(root.right);
    var cur = root.val;
    var sum = 0;
    
    if (left != Number.MIN_SAFE_INTEGER && right != Number.MIN_SAFE_INTEGER) {
        max = Math.max(cur + left + right, cur, left, right, cur + left, cur + right, max);
        sum = Math.max(cur, cur + left, cur + right);
    }
    else {
        if (left == Number.MIN_SAFE_INTEGER) {
            max = Math.max(cur, cur + right, right, max);
            sum = Math.max(cur, cur + right);
        }
        else if (right == Number.MIN_SAFE_INTEGER) {
            max = Math.max(cur, cur + left, left, max);
            sum = Math.max(cur, cur + left);
        }
        else {
            max = Math.max(cur, max);
            sum = cur;
        }
    }

    return sum;
}