/**
 * Link: https://leetcode.com/problems/palindrome-linked-list/
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
    public bool IsPalindrome(ListNode head) {
        ListNode low = head, fast = head;
        
        while(fast != null && fast.next != null) {
            low = low.next;
            fast = fast.next.next;
        }
        
        if (fast != null) low = low.next;
        
        low = Reverse(low);
        fast = head;
        
        while(low != null) {
            Console.WriteLine(fast.val + " " + low.val);
            if (fast.val != low.val) return false;
            
            low = low.next;
            fast = fast.next;
        }
        
        return true;
    }
    
    public ListNode Reverse(ListNode node) {
        if (node == null || node.next == null) return node;
        
        var first = node;
        var second = node.next;
        first.next = null;
        
        while(second != null) {
            var next = second.next;
            second.next = first;
            
            first = second;
            second = next;
        }
        
        return first;
    }
}