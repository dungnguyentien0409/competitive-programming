/**
 * Problem: https://leetcode.com/problems/path-sum-ii/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * Definition for a binary tree node.
 * function TreeNode(val) {
 *     this.val = val;
 *     this.left = this.right = null;
 * }
 */
/**
 * @param {TreeNode} root
 * @param {number} sum
 * @return {number[][]}
 */
var pathSum = function(root, sum) {
    var res = [];
    
    goSum(root, 0, sum, [], res);
    return res;
};

function goSum(node, curSum, sum, curRes, res) {
    if (node == null) return false;
    
    curSum += node.val;
    curRes.push(node.val);
    
    if (curSum == sum && isLeaf(node)) {
        res.push(curRes.slice(0));
    }
    
    goSum(node.left, curSum, sum, curRes, res);
    goSum(node.right, curSum, sum, curRes, res);
    
    
    var val = curRes.pop();
    curSum -= val;
}

function isLeaf(node) {
    return node.left == null && node.right == null;
}