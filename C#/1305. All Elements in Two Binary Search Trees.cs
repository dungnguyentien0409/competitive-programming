/**
 * Link: https://leetcode.com/problems/all-elements-in-two-binary-search-trees/submissions/
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
    public IList<int> GetAllElements(TreeNode root1, TreeNode root2) {
        var st1 = new Queue<int>();
        var st2 = new Queue<int>();
        
        InOrder(root1, st1);
        InOrder(root2, st2);
        
        var result = Merge(st1, st2);
        
        return result;
    }
    
    public List<int> Merge(Queue<int> st1, Queue<int> st2) {
        var res = new List<int>();
        
        while(st1.Count > 0 && st2.Count > 0) {
            if (st1.Peek() <= st2.Peek()) {
                res.Add(st1.Dequeue());
            }
            else {
                res.Add(st2.Dequeue());
            }
        }
        
        while(st1.Count > 0) {
            res.Add(st1.Dequeue());
        }
        
        while(st2.Count > 0) {
            res.Add(st2.Dequeue());
        }
        
        return res;
    }
    
    public void InOrder(TreeNode node, Queue<int> res) {
        if (node == null) return;
        
        InOrder(node.left, res);
        res.Enqueue(node.val);
        InOrder(node.right, res);
    }
}