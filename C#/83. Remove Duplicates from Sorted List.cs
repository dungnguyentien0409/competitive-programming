/**
 * Link: https://leetcode.com/problems/remove-duplicates-from-sorted-list/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
        if (head == null || head.next == null) return head;
        
        var current = head;
        
        while(current != null && current.next != null) {
            var next = current.next;
            
            if (current.val == next.val) {
                current.next = next.next;
                next.next = null;
            }
            else {
                current = current.next;
            }
        }
        
        return head;
    }
}