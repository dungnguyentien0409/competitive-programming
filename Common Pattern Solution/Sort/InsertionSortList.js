/*
 * Problem: Insertion Sort
 * Author: Dung Nguyen Tien (Chris)
*/

var insertionSortList = function(head) {
    if (head == null || head.next == null) return head;
    
    var start = new ListNode(Number.MIN_SAFE_INTEGER);
    start.next = head;
    var end = head;
    var node = head.next;
    
    while (node != null) {
        var cur = start;
        while(cur != end && cur.next != null && cur.next.val < node.val) cur = cur.next;
        
        if (cur == end) {
            end = node;
        }
        else {
            end.next = node.next;
            node.next = cur.next;
            cur.next = node;
            node = end;
        }
        
        node = node.next;
    }
    
    return start.next;
};