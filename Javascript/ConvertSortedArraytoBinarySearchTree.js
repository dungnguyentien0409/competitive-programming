/**
 * Problem: https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree/
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
var sortedArrayToBST = function(nums) {
    var root = buildTree(nums, 0, nums.length - 1);
    return root;
};

function buildTree(nums, left, right) {
    if (left > right) return null;
    
    var mid = Math.floor((left + right) / 2);
    var node = new TreeNode(nums[mid]);
    node.left = buildTree(nums, left, mid - 1);
    node.right = buildTree(nums, mid + 1, right);
    
    return node;
}