/**
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
    public ListNode[] SplitListToParts(ListNode head, int k) {
        int len = GetLength(head);
        int n = len / k, addition = len % k;
        var res = new ListNode[k];
        var cur = head;
        
        for (var i = 0; cur != null && i < k; i++, addition--) {
            res[i] = cur;
            
            ListNode pre = cur;
            for(var j = 0; j < n + (addition > 0 ? 1 : 0); j++) {
                pre = cur;
                cur = cur.next;
            }
            pre.next = null;
        }
        
        return res.ToArray();
    }
    
    public int GetLength(ListNode n) {
        if (n == null) return 0;
        
        return 1 + GetLength(n.next);
    }
}