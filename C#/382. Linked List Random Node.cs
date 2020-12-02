/**
 * Link: https://leetcode.com/problems/linked-list-random-node/
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
    int length;
    ListNode list;
    Random rd = new Random();

    /** @param head The linked list's head.
        Note that the head is guaranteed to be not null, so it contains at least one node. */
    public Solution(ListNode head) {
        this.list = head;
        
        while(head != null) {
            this.length++;
            head = head.next;
        }
    }
    
    /** Returns a random node's value. */
    public int GetRandom() {
        var index = rd.Next(0, length);
        var node = list;
        
        for (var i = 0; i < index; i++) {
            node = node.next;
        }
        
        return node.val;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(head);
 * int param_1 = obj.GetRandom();
 */