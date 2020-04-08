/**
 * Link: https://leetcode.com/problems/remove-duplicates-from-sorted-list-ii/submissions/
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
        
        var duplicates = new HashSet<int>();
        var current = head;
        
        while(current.next != null) {
            var next = current.next;
            
            if (current.val == next.val && !duplicates.Contains(current.val)) {
                duplicates.Add(current.val);
            }
            
            current = current.next;
        }
        
        var dummy = new ListNode(Int32.MinValue);
        var before = dummy;
        current = dummy;
        dummy.next = head;
        
        while(current != null) {
            current = current.next;
            if (current == null || !duplicates.Contains(current.val)) {
                before.next = current;
                before = before.next;
            }
        }
        
        return before == null || before.val != Int32.MinValue ? dummy.next : null;
    }
}