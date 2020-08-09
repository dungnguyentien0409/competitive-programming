/**
 * Link: https://leetcode.com/problems/vertical-order-traversal-of-a-binary-tree/
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
    public IList<IList<int>> VerticalTraversal(TreeNode root) {
        var map = new Dictionary<int, List<Node>>();
        
        Inorder(map, root, 0, 0);
        
        var res = FormatResult(map);
        
        return res;
    }
    
    public List<IList<int>> FormatResult(Dictionary<int, List<Node>> map) {
        var res = new List<IList<int>>();
        
        int min = map.Keys.Min(), max = map.Keys.Max();
        
        for (var k = min; k <= max; k++) {
            map[k].Sort(delegate(Node a, Node b) {
                if (a.x == b.x && a.y == b.y) return a.val - b.val; 
                
                return a.y - b.y;
            });
            
            var tmp = map[k].Select(s => s.val).ToList();
            res.Add(tmp);
        }
        
        return res;
    }
    
    public void Inorder(Dictionary<int, List<Node>> map, TreeNode node, int x, int y) {
        if (node == null) return;
        
        if (!map.ContainsKey(x)) map[x] = new List<Node>();
        
        map[x].Add(new Node(x, y, node.val));
        Inorder(map, node.left, x - 1, y + 1);
        Inorder(map, node.right, x + 1, y + 1);
    }
}

public class Node {
    public int x;
    public int y;
    public int val;
    
    public Node(int x1, int y1, int v) {
        x = x1;
        y = y1;
        val = v;
    }
}