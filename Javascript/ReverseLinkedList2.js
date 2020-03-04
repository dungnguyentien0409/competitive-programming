/**
 * Problem: https://leetcode.com/problems/reverse-linked-list-ii/
 * Author: Dung Nguyen Tien (Chris)
 * Definition for singly-linked list.
 * function ListNode(val) {
 *     this.val = val;
 *     this.next = null;
 * }
 */
/**
 * @param {ListNode} head
 * @param {number} m
 * @param {number} n
 * @return {ListNode}
 */
var reverseBetween = function(head, m, n) {
    var dummyNode = new ListNode(-1);
    dummyNode.next = head;
    
    var start = new ListNode();
    var before = dummyNode;
    var current = dummyNode.next;
    var after = new ListNode();
    var first = new ListNode;
    
    for (var i = 1; i <= n; i++) {
        // the start save the node before m, the first save the node m
        if (i >= m) {
            if (i == m) {
                start = before;
                first = current;
                console.log(start.val + "-" + first.val);
            }
            after = current.next;
            current.next = before;
            before = current;
            current = after;
        }   
        if (i == n) {
            first.next = after;
            start.next = before;
        }
        if (i < m) {
            before = current;
            current = current.next;
        }
    }
    
    return dummyNode.next;
};