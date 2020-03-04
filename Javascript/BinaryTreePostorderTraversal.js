/**
 * Problem: https://leetcode.com/problems/binary-tree-postorder-traversal/
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
var postorderTraversal = function(root) {
    var res = [];
    
    // left => right => node.val
    trace(root, res);
    return res;
};

function trace(root, res) {
    if (root == null) return;
    
    if(root.left != null) trace(root.left, res);
    if(root.right != null) trace(root.right, res);
    res.push(root.val);
}