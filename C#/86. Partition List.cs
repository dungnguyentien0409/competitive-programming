/**
 * Link: https://leetcode.com/problems/partition-list/
 * Author: Dung Nguyen Tien (Chris)
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
    public ListNode Partition(ListNode head, int x) {
        ListNode sHead = new ListNode(-1), bHead = new ListNode(-1);
        ListNode s = sHead, b = bHead;
        
        while(head != null) {
            if (head.val < x) {
                s.next = head;
                s = s.next;
            }
            else {
                b.next = head;
                b = b.next;
            }
            
            head = head.next;
        }
        
        s.next = bHead.next;
        b.next = null;
        
        return sHead.next;
    }
}