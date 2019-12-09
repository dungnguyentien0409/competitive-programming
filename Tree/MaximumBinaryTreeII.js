/**
 * Problem: https://leetcode.com/problems/maximum-binary-tree-ii/
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
var insertIntoMaxTree = function(root, val) {
    // use dummyNode
    var dummyNode = new TreeNode(Number.MAX_SAFE_INTEGER);
    dummyNode.right = root;
    
    var head = go(dummyNode, val);
    
    return head.right;
};

function go(dummyNode, val) {
    var root = dummyNode;
    
    while(dummyNode.val > val && (dummyNode.right != null && dummyNode.right.val > val)) {
        dummyNode = dummyNode.right;
    }

    var node = new TreeNode(val);
    node.left = dummyNode.right;
    dummyNode.right = node;
    
    return root;
}