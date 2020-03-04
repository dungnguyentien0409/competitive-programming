/**
 * Problem: https://leetcode.com/problems/vertical-order-traversal-of-a-binary-tree/
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
var verticalTraversal = function(root) {
    if (root == null) return [];
    
    var map = traversal(root);
    var res = sortByKeys(map);
    
    return res;
};

function traversal(node) {
    if (node == null) return;
    node.x = 0;
    var queue = [node];
    var map = {};
    
    while(queue.length > 0) {
        var len = queue.length;
        var tmp = {};
        
        for (var i = 0; i < len; i++) {
            var n = queue.pop();
            
            if (tmp[n.x] == undefined) tmp[n.x] = [n.val];
            else tmp[n.x].push(n.val);
            
            if (n.left != null) {
                n.left.x = n.x - 1;
                queue.unshift(n.left);
            }
            if (n.right != null) {
                n.right.x = n.x + 1;
                queue.unshift(n.right);
            }
        }
        
        pushTmpToMap(tmp, map);
    }
    return map;
}

function pushTmpToMap(tmp, map) {
    var keys = Object.keys(tmp);
    for (var k of keys) {
        tmp[k].sort((a, b) => a - b);
        
        map[k] = (map[k] || []).concat(tmp[k]);
    }
}

function sortByKeys(map) {
    var keys = Object.keys(map).sort(function(a, b) { return a - b; });
    var res = Array(keys.length).fill().map(() => []);
    var i = 0;

    for(var k of keys) {
        res[i++] = map[k].slice(0); 
    }

    return res;
}