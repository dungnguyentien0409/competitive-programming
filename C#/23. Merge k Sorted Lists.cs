/**
 * Link: https://leetcode.com/problems/merge-k-sorted-lists/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode MergeKLists(ListNode[] lists) {
        int min = Int32.MaxValue, imin = -1;
        var head = new ListNode(-1);
        var pointer = head;
        
        while(min == Int32.MaxValue) {
            for (var i = 0; i < lists.Length; i++) {
                if (lists[i] != null && lists[i].val < min) {
                    imin = i;
                    min = lists[i].val;
                }
            }
            
            if (min == Int32.MaxValue) break;
            
            pointer.next = new ListNode(min);
            pointer = pointer.next;
            
            // remove node from list
            lists[imin] = lists[imin].next;
            
            //updat min
            min = Int32.MaxValue;
            imin = -1;
        }
        
        return head.next;
    }
}