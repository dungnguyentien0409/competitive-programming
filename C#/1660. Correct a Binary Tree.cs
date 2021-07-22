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
    public TreeNode CorrectBinaryTree(TreeNode root) {
        if (root == null) return root;
        
        var set = new HashSet<int>();
        var queue = new Queue<Node>();
        queue.Enqueue(new Node(root, null));
        while(queue.Count > 0) {
            var len = queue.Count;
            
            for(var i = 0; i < len; i++) {
                var cur = queue.Dequeue();
                var node = cur.node;
                var parent = cur.parent;
                
                set.Remove(node.val);
                
                if (node.left != null) {
                    queue.Enqueue(new Node(node.left, node));
                    set.Add(node.left.val);
                }
                if (node.right != null) {
                    if (set.Contains(node.right.val)) {
                        if (parent.left != null && parent.left.val == node.val) {
                            parent.left = null;
                        }
                        else {
                            parent.right = null;
                        }
                        break;
                    }
                    queue.Enqueue(new Node(node.right, node));
                    set.Add(node.right.val);
                }
            }
        }
        
        return root;
    }
}

public class Node {
    public TreeNode node { get; set; }
    public TreeNode parent { get; set; }
    
    public Node(TreeNode n, TreeNode p) {
        node = n;
        parent = p;
    }
}