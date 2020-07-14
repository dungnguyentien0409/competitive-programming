/**
 * Link: https://leetcode.com/problems/add-two-numbers-ii/submissions/
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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        var st1 = GetNumber(l1);
        var st2 = GetNumber(l2);
        var res = new Stack<ListNode>();
        int r = 0;
        
        while(st1.Count > 0 && st2.Count > 0) {
            int val = st1.Pop() + st2.Pop() + r;
            r = 0;
            
            if (val >= 10) {
                val -= 10;
                r = 1;
            }
            
            res.Push(new ListNode(val));
        }
        
        while (st1.Count > 0) {
            int val = st1.Pop() + r;
            r = 0;
            
            if (val >= 10) {
                val -= 10;
                r = 1;
            }
            
            res.Push(new ListNode(val));
        }
        
        while (st2.Count > 0) {
            int val = st2.Pop() + r;
            r = 0;
            
            if (val >= 10) {
                val -= 10;
                r = 1;
            }
            
            res.Push(new ListNode(val));
        }
        
        if (r == 1) res.Push(new ListNode(r));
        
        var current = res.Pop();
        var head = current;
        while(res.Count > 0) {
            current.next = res.Pop();
            current = current.next;
        }
        
        return head;
    }
    
    public Stack<int> GetNumber(ListNode l) {
        var st = new Stack<int>();
        
        while(l != null) {
            st.Push(l.val);
            l = l.next;
        }
        
        return st;
    }
}