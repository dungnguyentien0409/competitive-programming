/*
 * Link: https://leetcode.com/problems/inorder-successor-in-bst-ii/
 * Author: Dung Nguyen Tien (Chris)
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node parent;
}
*/
public class Solution {
    public Node InorderSuccessor(Node x) {
        if (x.right != null) {
            x = x.right;
            
            while(x.left != null) {
                x = x.left;
            }
            
            return x;
        }
        else {
            Node tmp = x;
            
            while(x.parent != null) {
                x = x.parent;
                
                if (x.left == tmp) return x;
                
                tmp = x;
            }
        }
        
        return null;
    }
}