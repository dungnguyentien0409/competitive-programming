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
    public TreeNode SortedArrayToBST(int[] nums) {
        return BuildTree(nums, 0, nums.Length - 1);
    }
    
    public TreeNode BuildTree(int[] nums, int left, int right) {
        if (left > right) return null;
        
        var mid = left + (right - left) / 2;
        var node = new TreeNode(nums[mid]);
        node.left = BuildTree(nums, left, mid - 1);
        node.right = BuildTree(nums, mid + 1, right);
        
        return node;
    }
}