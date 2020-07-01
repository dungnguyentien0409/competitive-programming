/**
 * Link: https://leetcode.com/problems/all-nodes-distance-k-in-binary-tree/
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
    public IList<int> DistanceK(TreeNode root, TreeNode target, int K) {
        var map = new Dictionary<int, List<int>>();
        
        dfs(root.left, root, map);
        dfs(root.right, root, map);
        
        return bfs(map, target.val, K);
    }
    
    public List<int> bfs(Dictionary<int, List<int>> map, int target, int K) {
        var visited = new HashSet<int>();
        var queue = new Queue<int>();
        
        queue.Enqueue(target);
        visited.Add(target);
        
        while(queue.Count > 0) {
            if (K == 0) return queue.ToList();
            
            var len = queue.Count;
            
            for(var i = 0; i < len; i++) {
                var node = queue.Dequeue();
                
                var nexts = map[node];
                foreach(var next in nexts) {
                    if (!visited.Contains(next)) {
                        queue.Enqueue(next);
                        visited.Add(next);
                    }
                }
            }
            
            K--;
        }
        
        return new List<int>();
    }
    
    public void dfs(TreeNode node, TreeNode parent, Dictionary<int, List<int>> map) {
        if (node == null) {
            if (parent == null) return;
            
            if (!map.ContainsKey(parent.val)) map.Add(parent.val, new List<int>());
            return;
        }
        
        if (!map.ContainsKey(parent.val)) map.Add(parent.val, new List<int>());
        if (!map.ContainsKey(node.val)) map.Add(node.val, new List<int>());
        
        map[parent.val].Add(node.val);
        map[node.val].Add(parent.val);
        
        dfs(node.left, node, map);
        dfs(node.right, node, map);
    }
}