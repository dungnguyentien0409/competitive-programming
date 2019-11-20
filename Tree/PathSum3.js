/**
 * Problem: https://leetcode.com/problems/path-sum-iii/submissions/
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
 * @return {number}
 */
var pathSum = function(root, sum) {
    var count = 0;
    
    count = traversal(root, sum);
    console.log(count);
    return count;
};


function traversal(node, sum) {
    if (node == null) return 0;
    
    var c = goSum(node, 0, sum);
    if (node.left != null) c += traversal(node.left, sum);
    if (node.right != null) c += traversal(node.right, sum);
    
    return c;
}

function goSum(node, curS, sum) {
    if (node == null) return 0;
    
    curS += node.val;
    
    return (curS == sum ? 1 : 0) 
        + goSum(node.left, curS, sum) 
        + goSum(node.right, curS, sum);
}