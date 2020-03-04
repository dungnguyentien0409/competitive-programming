/**
 * Problem: https://leetcode.com/problems/reverse-linked-list-ii/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode ReverseBetween(ListNode head, int m, int n) {
        if (head.next == null) return head;
        
        var dummyNode = new ListNode(-1);
        dummyNode.next = head;
        
        var previous = dummyNode;
        var current = dummyNode.next;
        var first = current;
        var after = current.next;
        var i = 1;
        
        while (i <= n) {
            if (i >= m) {
                if (i == m) {
                    first = current;
                }
                current.next = previous;
            }
            
            if (i == n) break;
            
            previous = current;
            current = after;
            after = after.next;
            i++;
        }
        
        var start = first.next;
        first.next = after;
        start.next = current;
        
        return dummyNode.next;
    }
}