/**
 * Link: https://leetcode.com/problems/merge-two-sorted-lists/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * Definition for singly-linked list.
 * function ListNode(val) {
 *     this.val = val;
 *     this.next = null;
 * }
 */
/**
 * @param {ListNode} l1
 * @param {ListNode} l2
 * @return {ListNode}
 */
var mergeTwoLists = function(l1, l2) {
    var node1 = l1, node2 = l2;
    var head = new ListNode(), tmp = head;
    
    while(node1 != null && node2 != null) {
        if (node1.val <= node2.val) {
            tmp.next = node1;
            node1 = node1.next;
        }
        else {
            tmp.next = node2;
            node2 = node2.next;
        }
        tmp = tmp.next;
    }
    
    while(node1 != null) {
        tmp.next = node1;
        tmp = tmp.next;
        node1 = node1.next;
    }
    
    while(node2 != null) {
        tmp.next = node2;
        tmp = tmp.next;
        node2 = node2.next;
    }
    
    return head.next;
};