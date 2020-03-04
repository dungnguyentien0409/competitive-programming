/** 
 * Link: https://leetcode.com/problems/construct-binary-tree-from-inorder-and-postorder-traversal/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * Definition for a binary tree node.
 * function TreeNode(val) {
 *     this.val = val;
 *     this.left = this.right = null;
 * }
 */
/**
 * @param {number[]} inorder
 * @param {number[]} postorder
 * @return {TreeNode}
 */
var buildTree = function(inorder, postorder) {
    if (inorder.length == 0 || inorder.length != postorder.length) return null;
    
    var root = helper(postorder.length - 1, 0, inorder.length - 1, inorder, postorder);
    
    return root;
};

function helper(posStart, inStart, inEnd, inorder, postorder) {
    if (posStart < 0 || inStart > inEnd) return null;
    
    var node = new TreeNode(postorder[posStart]);
    var index = inorder.indexOf(node.val);
    var right_posStart = posStart - 1;
    var left_posStart = posStart - (inEnd - index) - 1;
    
    node.right = helper(right_posStart, index + 1, inEnd, inorder, postorder);
    node.left = helper(left_posStart, inStart, index - 1, inorder, postorder);
    
    return node;
}