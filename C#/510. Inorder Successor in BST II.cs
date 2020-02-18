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
        if (x == null) return x;
        
        if (x.right == null) {
            var result = x.parent;
            
            while(result != null && result.val < x.val) {
                result = result.parent;
            }
            
            return result;
        }
        else {
            var result = x.right;
            
            while(result != null && result.left != null) {
                result = result.left;
            }
            
            return result;
        }
    }
}