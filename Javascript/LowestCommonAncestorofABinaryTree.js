/**
 * Link: https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-tree/
 * Author: Dung Nguyen Tien (Chris)
 * Definition for a binary tree node.
 * function TreeNode(val) {
 *     this.val = val;
 *     this.left = this.right = null;
 * }
 */
/**
 * @param {TreeNode} root
 * @param {TreeNode} p
 * @param {TreeNode} q
 * @return {TreeNode}
 */
var lowestCommonAncestor = function(root, p, q) {
    var dummyNode = new TreeNode(-1);
    dummyNode.left = root;
    var lca = dummyNode;
    
    while(dummyNode != null) {
        var goLeft = go(dummyNode.left, p, q);
        var goRight = go(dummyNode.right, p, q);
        
        if (goLeft) {
            dummyNode = dummyNode.left;
            lca = dummyNode;
        }
        else if (goRight) {
            dummyNode = dummyNode.right;
            lca = dummyNode;
        }
        else {
            break;
        }
    }

    return lca;
};

function go(node, p, q) {
    if (node == null) return false;
    
    var count = 0;
    var queue = [node];
    
    while(queue.length > 0) {
        for (var i = 0; i < queue.length; i++) {
            var node = queue.shift();
            
            if (node.val == p.val || node.val == q.val) ++count;
            
            if (node.left != null) queue.push(node.left);
            if (node.right != null) queue.push(node.right);
        }
    }
    
    return count == 2;
}