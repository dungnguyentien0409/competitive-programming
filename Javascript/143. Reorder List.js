/**
 * Link: https://leetcode.com/problems/reorder-list/
 * Author: Dung Nguyen Tien (Chris)
 * Definition for singly-linked list.
 * function ListNode(val) {
 *     this.val = val;
 *     this.next = null;
 * }
 */
/**
 * @param {ListNode} head
 * @return {void} Do not return anything, modify head in-place instead.
 */
var reorderList = function(head) {
    if (head == null) return null;
    
    // pointer1 points to the middle
    var pointer1 = head, pointer2 = head;
    while(pointer1 && pointer2 && pointer2.next) {
        pointer1 = pointer1.next;
        pointer2 = pointer2.next.next;
    }
    
    // devide into 2 list and reverse the second half
    var head1 = head.next
    var head2 = reverse(pointer1.next);
    var order = head;
    pointer1.next = null
    
    while(head1 && head2) {
        order.next = head2;
        head2 = head2.next;
        order = order.next;
        
        order.next = head1;
        head1 = head1.next;
        order = order.next;
    }
    
    if (head1) order.next = head1;
    if (head2) order.next = head2;
    
    return head;
    
};

function reverse(head) {
    var st = [];
    var node = head;
    var reverse = new ListNode();
    
    while (node != null) {
        st.push(node);
        node = node.next;
    }
    
    var tmp = reverse;
    while(st.length > 0) {
        var top = st.pop();
        tmp.next = top;
        tmp = tmp.next;
    }
    tmp.next = null;
    
    return reverse.next;
}
