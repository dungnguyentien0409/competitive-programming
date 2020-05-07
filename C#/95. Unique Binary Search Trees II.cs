/**
 * Link: https://leetcode.com/problems/unique-binary-search-trees-ii/submissions/
 * Author: Dung Nguyen Tien (Chris)
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
    public IList<TreeNode> GenerateTrees(int n) {
        var res = Generate(1, n);
        
        return res;
    }
    
    public List<TreeNode> Generate(int min, int max) {
        var res = new List<TreeNode>();
        
        for (var n = min; n <= max; n++) {
            var listLeft = Generate(min, n - 1);
            var listRight = Generate(n + 1, max);
            var current = new TreeNode(n);
            
            if (listLeft.Count > 0 && listRight.Count > 0) {
                foreach(var left in listLeft) {
                    foreach(var right in listRight) {
                        var clone = Clone(current);
                        
                        clone.left = left;
                        clone.right = right;
                        res.Add(clone);
                    }
                }
            }
            else if (listLeft.Count > 0) {
                foreach(var left in listLeft) {
                    var clone = Clone(current);
                    clone.left = left;
                    
                    res.Add(clone);
                }
            }
            else if (listRight.Count > 0) {
                foreach(var right in listRight) {
                    var clone = Clone(current);
                    clone.right = right;
                    
                    res.Add(clone);
                }
            }
            else {
                res.Add(current);
            }
        }
        
        return res;
    }
    
    public TreeNode Clone(TreeNode node) {
        if (node == null) return null;
        
        var n = new TreeNode(node.val);
        
        n.left = Clone(node.left);
        n.right = Clone(node.right);
        
        return n;
    }
}