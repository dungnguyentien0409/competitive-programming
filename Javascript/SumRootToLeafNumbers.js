/**
 * Problem: https://leetcode.com/problems/sum-root-to-leaf-numbers/
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
var sumNumbers = function(root) {
    if (root == null) return 0;
    
    var res = [];
    goSum(root, res, 0);
    
    var sum = 0;
    for(var n of res) sum += n;
    
    return sum;
};

function goSum(node, res, current) {
    if (node == null) return;
    
    current = current * 10 + node.val;
    if (node.left == null && node.right == null) {
        res.push(current);
        return;
    }
    else if (node.left == null && node.right != null) {
        goSum(node.right, res, current);
    }
    else if (node.left != null && node.right == null) {
        goSum(node.left, res, current);
    }
    else {
        goSum(node.left, res, current);
        goSum(node.right, res, current);
    }
}