/**
 * Problem: https://leetcode.com/problems/maximum-binary-tree/
 * Author: Dung Nguyen Tien (Chris)
 * Definition for a binary tree node.
 * function TreeNode(val) {
 *     this.val = val;
 *     this.left = this.right = null;
 * }
 */
/**
 * @param {number[]} nums
 * @return {TreeNode}
 */
var constructMaximumBinaryTree = function(nums) {
    var root = buildTree(nums, 0, nums.length - 1);
    
    return root;
};

function buildTree(nums, left, right) {
    if (left > right || left < 0 || right >= nums.length) return null;
    
    var imax = left;
    for (var i = left; i <= right; i++) {
        if (nums[i] > nums[imax]) imax = i;
    }
    
    var node = new TreeNode(nums[imax]);
    node.left = buildTree(nums, left, imax - 1);
    node.right = buildTree(nums, imax + 1, right);
    
    return node;
}