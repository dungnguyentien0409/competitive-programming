/**
 * Link: https://leetcode.com/problems/serialize-and-deserialize-binary-tree/submissions/
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
    var res = [];
    
    serializeHelper(root, res);
    return res;
};

function serializeHelper(root, res) {
    if (root == null) {
        res.push(null);
        return;
    }
    
    res.push(root.val);
    serializeHelper(root.left, res);
    serializeHelper(root.right, res);
}
/**
 * Decodes your encoded data to tree.
 *
 * @param {string} data
 * @return {TreeNode}
 */
var deserialize = function(data) {
    var root = deserializeHelper(data);
    return root;
};

function deserializeHelper(arr) {
    if (arr.length == 0) return;
    
    var val = arr.shift();
    if (val == null) return null;
    
    var node = new TreeNode(val);
    node.left = deserializeHelper(arr);
    node.right = deserializeHelper(arr);
    
    return node;
}

/**
 * Your functions will be called as such:
 * deserialize(serialize(root));
 */