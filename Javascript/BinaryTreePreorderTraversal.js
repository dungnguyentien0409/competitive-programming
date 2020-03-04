/**
 * Link: https://leetcode.com/problems/binary-tree-preorder-traversal/
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
var preorderTraversal = function(root) {
    var res = [];
    
    // node.val => left => right
    trace(root, res);
    return res;
};
    
function trace(root, res) {
    if (root == null) return;
    
    res.push(root.val);
    if (root.left != null) trace(root.left, res);
    if (root.right != null) trace(root.right, res);
}