/**
 * Problem: https://leetcode.com/problems/intersection-of-two-linked-lists/
 * Author: Dung Nguyen Tien (Chris)
 * Reference: myfavcat123
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        // A length = a + c, B length = b + c
        // after switch they both go A: a + c + b +c , B: b + c + a + c
        // will meet at a + c + b
        if (headA == null || headB == null) return null;
        
        var a = headA;
        var b = headB;
        
        while(a != b) {
            a = a == null ? headB : a.next;
            b = b == null ? headA : b.next;
        }
        
        return a;
    }
}