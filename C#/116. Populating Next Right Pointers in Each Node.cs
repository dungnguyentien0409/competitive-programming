/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}
*/
/*
 * Link: https://leetcode.com/problems/populating-next-right-pointers-in-each-node/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public Node Connect(Node root) {
        if (root == null) return root;
        
        var queue = new Queue<Node>();
        
        queue.Enqueue(root);
        while(queue.Count > 0) {
            var len = queue.Count;
            
            for (var i = 0; i < len; i++) {
                var node = queue.Dequeue();
                
                if (i + 1 < len) {
                    node.next = queue.Peek();
                }
                else {
                    node.next = null;
                }
                
                if (node.left != null) queue.Enqueue(node.left);
                if (node.right != null) queue.Enqueue(node.right);
            }
        }
        
        return root;
    }
}