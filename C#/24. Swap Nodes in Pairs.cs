/**
 * Link: https://leetcode.com/problems/swap-nodes-in-pairs/
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
    public ListNode SwapPairs(ListNode head) {
        var dummyNode = new ListNode(Int32.MinValue);
        dummyNode.next = head;
        var start = dummyNode;
        
        while(start.next != null && start.next.next != null) {
            var first = start.next;
            var second = start.next.next;
            var afterSecond = second.next;
            
            start.next = second;
            second.next = first;
            first.next = afterSecond;
            
            start = first;
        }
        
        return dummyNode.next;
    }
}