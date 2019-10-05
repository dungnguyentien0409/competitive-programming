/**
 * Problem: https://leetcode.com/problems/kth-smallest-element-in-a-bst/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * Definition for a binary tree node.
 * function TreeNode(val) {
 *     this.val = val;
 *     this.left = this.right = null;
 * }
 */
/**
 * @param {TreeNode} root
 * @param {number} k
 * @return {number}
 */
var kthSmallest = function(root, k) {
    count = k;
    trace(root);
    return minK;
};

var count = 0;
var minK = 0;
// using inorder traversal: left => val => right
function trace(root, k) {
    if (root.left != null) trace(root.left);
    
    --count;
    if (count == 0) {
        minK = root.val;
    }
    
    if (root.right != null) trace(root.right)
}