/**
 * Link: https://leetcode.com/problems/odd-even-linked-list/
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
var oddEvenList = function(head) {
    if (head == null || head.next == null || head.next.next == null) return head;

    var odd = head, even = head.next, beginEven = even;
    
    while(even != null && even.next != null) {
        odd.next = odd.next.next;
        even.next = even.next.next;
        odd = odd.next;
        even = even.next;
    }
    
    odd.next = beginEven;
    return head;
};