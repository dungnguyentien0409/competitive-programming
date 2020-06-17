/**
 * Link: https://leetcode.com/problems/merge-two-sorted-lists/
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
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        var res = new ListNode(Int32.MinValue); 
        var n1 = l1;
        var n2 = l2;
        var current = res;
        
        while(n1 != null && n2 != null) {
            if (n1.val <= n2.val) {
                current.next = n1;
                n1 = n1.next;
                
                current = current.next;
                current.next = null;
            }
            else {
                current.next = n2;
                n2 = n2.next;
                
                current = current.next;
                current.next = null;
            }
        }
        
        if (n1 != null) current.next = n1;
        if (n2 != null) current.next = n2;
        
        return res.next;
    }
}