/**
 * Problem: https://leetcode.com/problems/linked-list-cycle/
 * Author: Dung Nguyen Tien (Chris)
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        if (head == null) return false;
        
        var low = head;
        var fast = head.next;
        
        while(fast != null && fast.next != null && low != fast) {
            low = low.next;
            fast = fast.next.next;
        }
        
        return low == fast;
    }
}