/**
 * Link: https://leetcode.com/problems/convert-sorted-list-to-binary-search-tree/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * Definition for singly-linked list.
 * function ListNode(val) {
 *     this.val = val;
 *     this.next = null;
 * }
 */
/**
 * Definition for a binary tree node.
 * function TreeNode(val) {
 *     this.val = val;
 *     this.left = this.right = null;
 * }
 */
/**
 * @param {ListNode} head
 * @return {TreeNode}
 */
var sortedListToBST = function(head) {
    var root = buildTree(head, null);
    return root;
};

function buildTree(left, right) {
    if (left == null || left == right) return null;
    
    var mid = getMid(left, right);
    var node = new TreeNode(mid.val);
    node.left = buildTree(left, mid);
    node.right = buildTree(mid.next, right);
    
    return node;
}

function getMid(left, right) {
    if (left == null || left == right) return left;
    
    var low = left;
    var fast = left;
    
    while(fast != right && fast.next != right) {
        low = low.next;
        fast = fast.next.next;
    }
    
    return low;
}