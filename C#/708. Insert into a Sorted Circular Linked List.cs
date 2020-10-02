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
#Sprint 1
Oct1 - Oct2: Asset Register - Component
Oct6 - Oct9: Asset Register - Tank, Characteristics, Design, Assessment
Oct12 - Oct16: Anomaly Data, Inspection Data, Metocean Data

#Sprint 2
Oct19 - Oct23 SIM Risk Ranking: View Component Risk Ranking, View Tank Risk Ranking
Oct26 - Oct30 Inspection Plan
Nov2 - Nov6 KPI Dashboard, KPI Management Summary, SIM Risk Ranking: View Hull Risk Ranking

#Sprint 3
Nov9 - Nov13 Dashboard, Document Register
Nov16 - Nov20 Utilities
Nov23 - Nov27

#Sprint 4
Dec30 - Dec4