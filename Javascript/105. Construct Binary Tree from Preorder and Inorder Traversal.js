/**
 * Link: https://leetcode.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * Definition for a binary tree node.
 * function TreeNode(val) {
 *     this.val = val;
 *     this.left = this.right = null;
 * }
 */
/**
 * @param {number[]} preorder
 * @param {number[]} inorder
 * @return {TreeNode}
 */
var buildTree = function(preorder, inorder) {
    if (preorder.length == 0 || preorder.length != inorder.length) return null;
    
    var root = helper(0, 0, inorder.length - 1, preorder, inorder);
    
    return root;
};

function helper(preStart, inStart, inEnd, preorder, inorder) {
    if (preStart >= preorder.length || inStart > inEnd) return null;
    
    var node = new TreeNode(preorder[preStart]);
    
    var index = inorder.indexOf(node.val);
    var left_preStart = preStart + 1;
    // plus the node on the left of current node
    var right_preStart = preStart + (index - inStart) + 1;
    
    node.left = helper(left_preStart, inStart, index - 1, preorder, inorder);
    node.right = helper(right_preStart, index + 1, inEnd, preorder, inorder);
    
    return node
}