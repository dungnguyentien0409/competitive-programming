/*
 * Link: https://leetcode.com/problems/insert-into-a-sorted-circular-linked-list/submissions/
 * Author: Dung Nguyen Tien (Chris)
// Definition for a Node.
public class Node {
    public int val;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
        next = null;
    }

    public Node(int _val, Node _next) {
        val = _val;
        next = _next;
    }
}
*/

public class Solution {
    public Node Insert(Node head, int insertVal) {
        var node = new Node(insertVal);
        
        if (head == null) {
            node.next = node;
            return node;
        }
        
        var cur = head;
        while(true) {
            if (cur.val > cur.next.val && (node.val >= cur.val || node.val <= cur.next.val)
               || cur.val <= node.val && node.val <= cur.next.val
               || cur.next == head) 
                break;
            cur = cur.next;
        }
        
        node.next = cur.next;
        cur.next = node;
        
        return head;
    }
}