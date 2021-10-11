/**
 * // Definition for a Node.
 * function Node(val, children) {
 *    this.val = val === undefined ? 0 : val;
 *    this.children = children === undefined ? [] : children;
 * };
 */

/**
 * @param {Node} root
 * @return {number}
 */
var diameter = function(root) {
    max = 1;
    
    postOrder(root);
    
    return max - 1;
};

var max;

function postOrder(node) {
    if (node == null) return 0;
    
    var max1 = 0, max2 = 0;
    
    if (node.children) {
        for(var child of node.children) {
            var len = postOrder(child);

            if (len > max2) {
                max1 = max2;
                max2 = len;
            }
            else if (len > max1) {
                max1 = len;
            }

            max = Math.max(max, 1 + max1 + max2);
        }
    }
    
    console.log(max2);
    return 1 + max2;
}