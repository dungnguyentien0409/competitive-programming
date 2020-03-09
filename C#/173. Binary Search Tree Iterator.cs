/**
 * Link: https://leetcode.com/problems/binary-search-tree-iterator/
 * Author: Dung Nguyen Tien (Chris)
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class BSTIterator {
    List<int> list;
    int current;
    
    public BSTIterator(TreeNode root) {
        list = new List<int>();
        current = 0;
        
        InOrder(root, list);
    }
    
    /** @return the next smallest number */
    public int Next() {
        return list[current++];
    }
    
    /** @return whether we have a next smallest number */
    public bool HasNext() {
        return current < list.Count;
    }
    
    private void InOrder(TreeNode node, List<int> list) {
        if (node == null) return;
        
        InOrder(node.left, list);
        list.Add(node.val);
        InOrder(node.right, list);
    }
}

/**
 * Your BSTIterator object will be instantiated and called as such:
 * BSTIterator obj = new BSTIterator(root);
 * int param_1 = obj.Next();
 * bool param_2 = obj.HasNext();
 */