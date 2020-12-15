/**
 * Link: https://leetcode.com/problems/plus-one-linked-list/
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
    public ListNode PlusOne(ListNode head) {
        var st = new Stack<ListNode>();
        var cur = head;
        
        while(cur != null) {
            st.Push(cur);
            cur = cur.next;
        }
        
        int remember = 1;
        while(st.Count > 0) {
            var node = st.Pop();
            
            node.val = node.val + remember;
            remember = node.val > 9 ? 1 : 0;
            node.val = node.val % 10;
            
            node.next = cur;
            cur = node;
        }
        
        if (remember == 1) {
            var node = new ListNode(1);
            
            node.next = cur;
            cur = node;
        }
        
        return cur;
    }
}