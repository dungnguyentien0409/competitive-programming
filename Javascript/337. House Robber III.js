/**
 * Link: https://leetcode.com/problems/house-robber-iii/submissions/
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
var rob = function(root) {
    if (root == null) return 0;
    
    return robHouse(root);
};

function robHouse(root) {
    // use map to save the maximum of robbing that rob
    // at any root, we can rob it and its grandchildren
    // or we skip it and rob their children
    if (root == null) return 0;
    
    var children = 0, grandChildren = 0;
    children += robHouse(root.left) + robHouse(root.right);
    
    if (root.left != null) 
        grandChildren += robHouse(root.left.left) + robHouse(root.left.right);
    if (root.right != null) 
        grandChildren += robHouse(root.right.left) + robHouse(root.right.right);
    
    return Math.max(root.val + grandChildren, children);
}