/** 
 * Link: https://leetcode.com/problems/binary-tree-right-side-view/submissions/
 * Author: Dung Nguyen Tien (Chris)
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public IList<int> RightSideView(TreeNode root) {
        var res = new List<int>();
        var queue = new Queue<TreeNode>();
        var viewed = false;
        queue.Enqueue(root);
        
        while(queue.Count > 0) {
            var n = queue.Count;
            viewed = false;
            
            for (int i = 0; i < n; i++) {
                var last = queue.Dequeue();
                
                if (last != null) {
                    if (!viewed) {
                        res.Add(last.val);
                        viewed = true;
                    }
                    
                    queue.Enqueue(last.right);
                    queue.Enqueue(last.left);
                }
            }
        }
        
        return res;
    }
}