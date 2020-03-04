/**
 * Problem: https://leetcode.com/problems/validate-binary-search-tree/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * Definition for a binary tree node.
 * function TreeNode(val) {
 *     this.val = val;
 *     this.left = this.right = null;
 * }
 */
/**
 * @param {TreeNode} root
 * @return {boolean}
 */
var isValidBST = function(root) {
    if (root == null) return true;
    
    var st = [];
    var pre = null;
    while(root != null || st.length != 0) {
        while(root != null) {
            st.push(root);
            root = root.left;
        }
        
        root = st.pop();
        // we go from the farthest left to right, so the current element must greater than the pre
        if (pre != null && root.val <= pre.val) return false;
        pre = root;
        root = root.right;
    }
    
    return true;
};