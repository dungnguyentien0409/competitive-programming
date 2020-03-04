/**
 * Link: https://leetcode.com/problems/reverse-linked-list/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode ReverseList(ListNode head) {
        if (head == null || head.next == null) return head;
        
        var pre = head;
        var current = head.next;
        var after = current.next;
        head.next = null;
        
        while(current != null) {
            current.next = pre;    
            
            if (after == null) break;
            pre = current;
            current = after;
            after = after.next;
        }
        
        return current;
    }
}