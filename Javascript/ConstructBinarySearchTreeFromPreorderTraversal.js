/**
 * Link: https://leetcode.com/problems/construct-binary-search-tree-from-preorder-traversal/
 * Author: Dung Nguyen Tien (Chris)
 * Definition for a binary tree node.
 * function TreeNode(val) {
 *     this.val = val;
 *     this.left = this.right = null;
 * }
 */
/**
 * @param {number[]} preorder
 * @return {TreeNode}
 */
var bstFromPreorder = function(preorder) {
    var root = helper(preorder, Number.MAX_SAFE_INT, Number.MIN_SAFE_INT);
    
    return root;
};

function helper(preorder, max, min) {
    if (preorder.length == 0) return null;
    
    if (preorder[0] >= max || preorder[0] <= min) return null;
    
    var node = new TreeNode(preorder.shift());
    node.left = helper(preorder, node.val, min);
    node.right = helper(preorder, max, node.val);
    
    return node;
}