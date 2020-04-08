/**
 * Link: https://leetcode.com/problems/middle-of-the-linked-list/
 * Author: Dung Nguyen Tien (Chris)
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode MiddleNode(ListNode head) {
        if (head == null) return null;
        
        var low = head;
        var fast = head;
        
        while(fast != null && fast.next != null) {
            low = low.next;
            fast = fast.next.next;
        }
        
        return low;
    }
}