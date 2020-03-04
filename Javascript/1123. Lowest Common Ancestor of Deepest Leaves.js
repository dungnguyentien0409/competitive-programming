/**
 * Link: https://leetcode.com/problems/lowest-common-ancestor-of-deepest-leaves/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * Definition for a binary tree node.
 * function TreeNode(val) {
 *     this.val = val;
 *     this.left = this.right = null;
 * }
 */
/**
 * @param {TreeNode} root
 * @return {TreeNode}
 */
var lcaDeepestLeaves = function(root) {
    // calculate the left and the right high
    // if both is equal then return the current node
    // else follow the higher
    if (root == null || (root.left == null && root.right == null)) return root;
    
    var left = goDown(root.left);
    var right = goDown(root.right);
    
    if (left == right) return root;
    else if (left > right) return lcaDeepestLeaves(root.left);
    else return lcaDeepestLeaves(root.right);
};

function goDown(node) {
    if (node == null) return 0;
    
    var left = 1 + goDown(node.left);
    var right = 1 + goDown(node.right);
    
    return Math.max(left, right);
}