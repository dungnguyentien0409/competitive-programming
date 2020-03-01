/**
 * Link: https://leetcode.com/problems/construct-binary-tree-from-string/
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
    public TreeNode Str2tree(string s) {
        if (s.Length == 0 || s == "()") return null;
        
        var number = GetFirstNumber(s);
        var node = new TreeNode(number);
        
        var deserialize = Deserialize(s.Substring(number.ToString().Length));
        
        node.left = Str2tree(deserialize[0]);
        node.right = Str2tree(deserialize[1]);
        
        return node;
    }
    
    public int GetFirstNumber(string s) {
        int i;
        for (i = 0; i < s.Length; i++) {
            if (s[i] == '(') break;
        }
        
        return Int32.Parse(s.Substring(0, i));
    }
    
    public string[] Deserialize(string s) {
        if (s.Length == 0) return new string[2] { "", "" };
        
        var result = new string[2] { "", "" };
        var count = 0;
        var i = 0;
        for (i = 0; i < s.Length; i++) {
            if (s[i] == '(') count++;
            else if (s[i] == ')') count--;
            
            if (count == 0) break;
        }
        
        if (i > 1) {
            result[0] = s.Substring(1, i - 1);
        }
        if (i + 2 < s.Length) {
            result[1] = s.Substring(i + 2, s.Length - i - 3);
        }
        
        return result;
    }
}