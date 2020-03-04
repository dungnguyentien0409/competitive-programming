/**
 * Problem: https://leetcode.com/problems/two-sum-bsts/
 * Author: Dung Nguyen Tien (Chris)
 * Definition for a binary tree node.
 * function TreeNode(val) {
 *     this.val = val;
 *     this.left = this.right = null;
 * }
 */
/**
 * @param {TreeNode} root1
 * @param {TreeNode} root2
 * @param {number} target
 * @return {boolean}
 */
var twoSumBSTs = function(root1, root2, target) {
    var map = {};
    
    // create the map to store finding value: target - root1.val
    createMap(root1, target, map);
    
    // check if the finding value exists in root2
    var res = findValue(root2, target, map);
    
    return res;
};

function createMap(root1, target, map) {
    // using preorder traversal
    if (root1 == null) return;
    
    // create the finding value as key and push to map
    var key = target - root1.val;
    map[key] = root1.val;
    
    if (root1.left != null) createMap(root1.left, target, map);
    if (root1.right != null) createMap(root1.right, target, map);
}

function findValue(root2, target, map) {
    // using preorder traversal
    if (root2 == null) return false;
    
    // check if the finding value exists in map
    var res = false;
    var key = root2.val;
    if (!isNaN(map[key])) {
        res = res || true;
    }
    
    if (root2.left != null) res = res || findValue(root2.left, target, map);
    if (root2.right != null) res = res || findValue(root2.right, target, map);
    
    return res;
}