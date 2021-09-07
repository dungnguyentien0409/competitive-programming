/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode ReverseBetween(ListNode head, int left, int right) {
        var dummy = new ListNode(-1);
        dummy.next = head;
        
        ListNode prev = dummy;
        for(var i = 0; i < left - 1; i++) {
            prev = prev.next;
        }
        
        ListNode cur = prev.next;
        for (var i = left; i < right; i++) {
            var next = cur.next;
            cur.next = next.next;
            next.next = prev.next;
            prev.next = next;
        }
        
        return dummy.next;
    }
}