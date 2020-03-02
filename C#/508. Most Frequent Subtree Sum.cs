/**
 * Link: https://leetcode.com/problems/most-frequent-subtree-sum/submissions/
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
    public int[] FindFrequentTreeSum(TreeNode root) {
        maxFrequent = Int32.MinValue;
        var map = new Dictionary<int, int>();
        var result = new List<int>();
        
        GoSum(root, map);
        
        foreach(var key in map.Keys.ToList()) {
            if (map[key] == maxFrequent) {
                result.Add(key);
            }
        }
        
        return result.ToArray();
    }
    
    int maxFrequent;
    public int GoSum(TreeNode node, Dictionary<int, int> map) {
        if (node == null) return 0;
        
        var sum = node.val;
        if (node.left == null && node.right == null) {
            if (!map.ContainsKey(node.val)) map.Add(node.val, 0);
        }
        else {
            sum += (GoSum(node.left, map) + GoSum(node.right, map));
            
            if (!map.ContainsKey(sum)) map.Add(sum, 0);
        }
        
        map[sum]++;
        maxFrequent = Math.Max(maxFrequent, map[sum]);
        
        return sum;
    }
}