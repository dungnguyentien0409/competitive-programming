/**
 * Link: https://leetcode.com/problems/convert-sorted-list-to-binary-search-tree/
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
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public TreeNode SortedListToBST(ListNode head) {
        if (head == null) return null;
        
        var root = BuildTree(head, null);
        
        return root;
    }
    
    public TreeNode BuildTree(ListNode left, ListNode right) {
        if (left == null || left == right) return null;
        
        var mid = GetMid(left, right);
        var node = new TreeNode(mid.val);
        node.left = BuildTree(left, mid);
        node.right =BuildTree(mid.next, right);
        
        return node;
    }
    
    public ListNode GetMid(ListNode left, ListNode right) {
        if (left == null || left == right) return left;
        
        ListNode low = left, fast = left;
        while(fast != right && fast.next != right) {
            low = low.next;
            fast = fast.next.next;
        }
        
        return low;
    }
}