/**
 * Problem: https://leetcode.com/problems/binary-tree-inorder-traversal/
 * Author: Dung Nguyen Tien (Chris)
 * Definition for a binary tree node.
 * function TreeNode(val) {
 *     this.val = val;
 *     this.left = this.right = null;
 * }
 */
/**
 * @param {TreeNode} root
 * @return {number[]}
 */
var inorderTraversal = function(root) {
    var res = [];
    
    // left => node.val => right
    trace(root, res);
    return res;
};

function trace(root, res) {
    if (root == null) return;
    
    if (root.left != null) trace(root.left, res);
    
    res.push(root.val);

    if (root.right != null) trace(root.right, res);
}