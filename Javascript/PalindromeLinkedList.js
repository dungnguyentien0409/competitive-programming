/**
 * Problem: https://leetcode.com/problems/palindrome-linked-list/
 * Author: Dung Nguyen Tien (Chris)
 * Definition for singly-linked list.
 * function ListNode(val) {
 *     this.val = val;
 *     this.next = null;
 * }
 */
/**
 * @param {ListNode} head
 * @return {boolean}
 */
var isPalindrome = function(head) {
    if (head == null) return true;
    var str1 = "";
    var str2 = "";
    var begin = head;
    
    // str1 is the left to right linkedlist item
    while (head != null) {
        str1 += head.val;
        head = head.next;
    }
    
    // str2 is the right to left linkedlist item
    str2 = traceBack(begin);
    
    // return if both are the same
    return str1 == str2;
};

function traceBack(head) {
    var res = "";
    if (head.next != null) res = traceBack(head.next);
    
    return res += head.val;
}