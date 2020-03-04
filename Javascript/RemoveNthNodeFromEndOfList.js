/**
 * Link: https://leetcode.com/problems/remove-nth-node-from-end-of-list/
 * Author: Dung Nguyen Tien (Chris)
 * Definition for singly-linked list.
 * function ListNode(val) {
 *     this.val = val;
 *     this.next = null;
 * }
 */
/**
 * @param {ListNode} head
 * @param {number} n
 * @return {ListNode}
 */
var removeNthFromEnd = function(head, n) {
    var dummyNode = new ListNode(-1);
    dummyNode.next = head;
    var low = dummyNode;
    var fast = dummyNode;
    
    // the distance from low and fase is n
    for (var i = 0; i <= n; i++) fast = fast.next;
    
    // low will point to the element right to the nth element
    while (fast != null) {
        low = low.next;
        fast = fast.next;
    }

    // remove the nth element
    low.next = low.next.next;
    return dummyNode.next;
};