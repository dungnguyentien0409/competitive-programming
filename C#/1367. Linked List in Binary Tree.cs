/**
 * Link: https://leetcode.com/problems/linked-list-in-binary-tree/
 * Author: Dung Nguyen Tien (Chris)
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public bool IsSubPath(ListNode head, TreeNode root) {
        if (head == null) return true;
        if (root == null) return false;
        
        return dfs(head, root) || IsSubPath(head, root.left) || IsSubPath(head, root.right);
    }
    
    public bool dfs(ListNode head, TreeNode root) {
        if (head == null) return true;
        if (root == null) return false;
        
        if (head.val != root.val) return false;
        
        return dfs(head.next, root.left) || dfs(head.next, root.right);
    }
}