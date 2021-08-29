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
    public bool CheckEqualTree(TreeNode root) {
        var set = new HashSet<int>();
        
        int total = Sum(root, root, set);
        
        return total % 2 == 0 && set.Contains(total / 2);
    }
    
    public int Sum(TreeNode root, TreeNode node, HashSet<int> set) {
        if (node == null) return 0;
        
        var left = Sum(root, node.left, set);
        var right = Sum(root, node.right, set);
        var sum = node.val + left + right;
        
        if (node != root) {
            set.Add(sum);
        }
        
        return sum;
    }
}