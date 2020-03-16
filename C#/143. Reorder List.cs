/**
 * Link: https://leetcode.com/problems/reorder-list/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public void ReorderList(ListNode head) {
        if (head == null) return;
        
        var header1 = head;
        var header2 = GetMiddle(head);
        header2 = ReverseList(header2);
        
        var result = new ListNode(-1);
        var current = result;
        
        while(header1 != null && header2 != null) {
            current.next = header1;
            header1 = header1.next;
            current = current.next;
            
            current.next = header2;
            header2 = header2.next; 
            current = current.next;
        }
        
        if (header1 != null) current.next = header1;
        if (header2 != null) current.next = header2;
        
        head = result.next;
    }
    
    public ListNode ReverseList(ListNode head) {
        ListNode prev = null;
        ListNode current = head;
        ListNode next = null;
        
        while(current != null) {
            next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }
        
        return prev;
    }
    
    public ListNode GetMiddle(ListNode head) {
        var low = head;
        var fast = head.next;
        
        while(fast != null && fast.next != null) {
            low = low.next;
            fast = fast.next.next;
        }
        
        var mid = low.next;
        low.next = null;
        return mid;
    }
}