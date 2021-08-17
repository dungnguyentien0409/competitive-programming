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
    public int GoodNodes(TreeNode root, int max = Int32.MinValue) {
        if (root == null) return 0;
        
        int count = 0;
        if (root.val >= max) count = 1;
        
        return count + GoodNodes(root.left, Math.Max(max, root.val))
            + GoodNodes(root.right, Math.Max(max, root.val));
    }
}