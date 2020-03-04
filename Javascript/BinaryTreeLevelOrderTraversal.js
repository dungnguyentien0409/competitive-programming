/**
 * Problem: https://leetcode.com/problems/binary-tree-level-order-traversal/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * Definition for a binary tree node.
 * function TreeNode(val) {
 *     this.val = val;
 *     this.left = this.right = null;
 * }
 */
/**
 * @param {TreeNode} root
 * @return {number[][]}
 */
var levelOrder = function(root) {
    if (root == null) return [];
    
    var res = [];
    var queue = [root];
    
    // use bfs to trace
    while(queue.length > 0) {
        var n = queue.length;
        var level = [];
        
        for (var i = 0; i < n; i ++) {
            var node = queue.pop();
            level.push(node.val);
            
            if (node.left != null) queue.unshift(node.left);
            if (node.right != null) queue.unshift(node.right);
        }
        
        res.push(level);
    }
    
    return res;
};