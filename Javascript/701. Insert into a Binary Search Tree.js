/**
 * Link: https://leetcode.com/problems/insert-into-a-binary-search-tree/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * Definition for a binary tree node.
 * function TreeNode(val) {
 *     this.val = val;
 *     this.left = this.right = null;
 * }
 */
/**
 * @param {TreeNode} root
 * @param {number} val
 * @return {TreeNode}
 */
var insertIntoBST = function(root, val) {
    var node = root;
    
    // find position to insert node, go right if val > current, go left if val < current. until find null position
    while (true) {
        if (node.val < val) {
            if (node.right == null) {
                node.right = new TreeNode(val);
                return root;
            }
            else node = node.right;
        }
        else {
            if (node.left == null) {
                node.left = new TreeNode(val);
                return root;
            }
            else node = node.left;
        }
    }
    
    return root;
};