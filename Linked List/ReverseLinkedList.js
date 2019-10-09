/**
 * Problem: https://leetcode.com/problems/reverse-linked-list/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * Definition for singly-linked list.
 * function ListNode(val) {
 *     this.val = val;
 *     this.next = null;
 * }
 */
/**
 * @param {ListNode} head
 * @return {ListNode}
 */
var reverseList = function(head) {
    if (head == null) return head;
    
    var ans =  reverse(head);
    return ans;
};

function reverse(originNode) {
    var reverseNode = null;
    // recursion to the end
    if (originNode.next != null) reverseNode = reverse(originNode.next, reverseNode);
    
    // trace back from the end
    if(reverseNode == null) {
        reverseNode = new ListNode(originNode.val);
        return reverseNode;
    }
    
    var tmp = reverseNode;
    while(tmp.next != null) tmp = tmp.next;
    tmp.next = new ListNode(originNode.val);
    
    return reverseNode;
}