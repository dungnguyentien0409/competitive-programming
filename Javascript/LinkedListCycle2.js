/**
 * Problem: https://leetcode.com/problems/linked-list-cycle-ii/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * Definition for singly-linked list.
 * function ListNode(val) {
 *     this.val = val;
 *     this.next = null;
 * }
 */

/**
 * @param {ListNode} head
 * @return {ListNode}
 */
var detectCycle = function(head) {
    if (head == null || head.next == null) return null;
    
    var low = head;
    var fast = head;
    
    while(fast != null && fast.next != null) {
        low = low.next;
        fast = fast.next.next;
        
        if (low == fast) {
            break;
        }
    }

    if (low != fast) return null;
    
    var first = head;
    var second = low;
    
    while(first != second) {
        first = first.next;
        second = second.next;
    }
    
    return first;
};