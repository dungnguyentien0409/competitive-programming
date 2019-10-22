/**
 * Problem: https://leetcode.com/problems/merge-k-sorted-lists/
 * Author: Dung Nguyen Tien (Chris)
 * Definition for singly-linked list.
 * function ListNode(val) {
 *     this.val = val;
 *     this.next = null;
 * }
 */
/**
 * @param {ListNode[]} lists
 * @return {ListNode}
 */
var mergeKLists = function(lists) {
    var head = new ListNode();
    var tmp = head;
    var iMin = 0;
    var min = Number.MAX_SAFE_INTEGER;
    
    while(min == Number.MAX_SAFE_INTEGER) {
        for (var i = 0; i < lists.length; i++) {
            var list = lists[i];
            
            if (list != null && list.val < min) {
                min = list.val;
                iMin = i;
            }
        }
        
        if (min == Number.MAX_SAFE_INTEGER) break;
        
        // add nodeMin value to tmp
        var nodeMin = lists[iMin];
        tmp.next = nodeMin;
        tmp = tmp.next;

        //remove nodeMin from list
        lists[iMin] = lists[iMin].next;
        nodeMin.next = null;
        
        min = Number.MAX_SAFE_INTEGER;
    }
    
    return head.next;
};