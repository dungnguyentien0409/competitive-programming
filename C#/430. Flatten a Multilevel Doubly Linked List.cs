/*
 * Link: https://leetcode.com/problems/flatten-a-multilevel-doubly-linked-list/
 * Author: Dung Nguyen Tien (Chris)
// Definition for a Node.
public class Node {
    public int val;
    public Node prev;
    public Node next;
    public Node child;
}
*/

public class Solution {
    public Node Flatten(Node head) {
        Node current = head;
        
        while(current != null) {
            if (current.child != null) {
                var child = current.child;
                
                while(child.next != null) child = child.next;
                
                var next = current.next;
                child.next = next;
                if (next != null) next.prev = child;
                
                current.next = current.child;
                current.child.prev = current;
                current.child = null;
            }
            
            current = current.next;
        }
        
        return head;
    }
}