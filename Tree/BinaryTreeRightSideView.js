/**
 * Problem: https://leetcode.com/problems/binary-tree-right-side-view/
 * Author: Dung Nguyen Tien (Chris)
 * Definition for a binary tree node.
 * function TreeNode(val) {
 *     this.val = val;
 *     this.left = this.right = null;
 * }
 */
/**
 * @param {TreeNode} root
 * @return {number[]}
 */
var rightSideView = function(root) {
    var result = [];
    var queue = [root];
    var viewed = false;
    
    // for level add the most right using bfs
    while (queue.length > 0) {
        var n = queue.length;
        viewed = false;
        
        for (var i = 0; i < n; i++) {
            var last = queue.pop();
            
            if (last != null) {
                //console.log(last.val);
                if (!viewed) {
                    result.push(last.val);
                    viewed = true;
                }    
            
                queue.unshift(last.right);
                queue.unshift(last.left);
            }
        }
    }
    
    return result;
};