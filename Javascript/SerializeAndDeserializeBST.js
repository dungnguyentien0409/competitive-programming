/**
 * Problem: https://leetcode.com/problems/serialize-and-deserialize-bst/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * Definition for a binary tree node.
 * function TreeNode(val) {
 *     this.val = val;
 *     this.left = this.right = null;
 * }
 */

/**
 * Encodes a tree to a single string.
 *
 * @param {TreeNode} root
 * @return {string}
 */
var serialize = function(root) {
    if (root == null) return [];
    
    var res = [];
    
    serializeHeper(root, res);
    
    return res;
};

function serializeHeper(node, res) {
    if (node == null) return;
    
    res.push(node.val);
    serializeHeper(node.left, res);
    serializeHeper(node.right, res);
}

/**
 * Decodes your encoded data to tree.
 *
 * @param {string} data
 * @return {TreeNode}
 */
var deserialize = function(data) {
    if (data.length == 0) return null;
    
    var root = deserializeHeper(data, Number.MAX_SAFE_INT, Number.MIN_SAFE_INT);
    
    return root;
};

function deserializeHeper(data, max, min) {
    if (data.length == 0) return null;
    
    if (data[0] >= max || data[0] <= min) return null;
    
    var node = new TreeNode(data.shift());
    node.left = deserializeHeper(data, node.val, min);
    node.right = deserializeHeper(data, max, node.val);
    
    return node;
}

/**
 * Your functions will be called as such:
 * deserialize(serialize(root));
 */