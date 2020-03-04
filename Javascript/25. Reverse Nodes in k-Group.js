/**
 * Link: https://leetcode.com/problems/reverse-nodes-in-k-group/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * Definition for singly-linked list.
 * function ListNode(val) {
 *     this.val = val;
 *     this.next = null;
 * }
 */
/**
 * @param {ListNode} head
 * @param {number} k
 * @return {ListNode}
 */
var reverseKGroup = function(head, k) {
    if (head==null || head.next ==null || k==1)
    	return head;
    
    var dummyhead = new ListNode(-1);
    var begin = dummyhead;
    
    dummyhead.next = head;
    
    var i = 0;
    while (head != null){
    	i++;
        head = head.next;
        
        // reverse from begin to head (exclude the begin node and head node)
    	if (i % k == 0){
    		begin = reverse(begin, head);
    	}
    }
    return dummyhead.next;
};

function reverse(begin, end) {
    // reverse every node inside bein and end excludes begin and end
    // save 3 node, prev, current and next. then do reverse, the current poit back to the previous, then moveon
    var prev = begin;
    var cur = prev.next;
    var next = new ListNode();
    var first = cur;
    
    while(next != end) {
        next = cur.next;
        cur.next = prev;
        prev = cur;
        cur = next;
    }
    
    // finally the first node (which first point back to the head, now point to the end)
    // and the head node point to the last
    first.next = end;
    begin.next = prev;
    
    return first;
}