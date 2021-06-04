/*
 * Link: https://leetcode.com/problems/open-the-lock/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int OpenLock(string[] deadends, string target) {
        if (Array.IndexOf(deadends, "0000") >= 0) return -1;
        
        var queue = new Queue<string>();
        var visited = new HashSet<string>(deadends);
        int res = 0;
        
        queue.Enqueue("0000");
        visited.Add("0000");
        while(queue.Count > 0) {
            var len = queue.Count;
            
            for (var i = 0; i < len; i++) {
                var node = queue.Dequeue();
                Console.WriteLine(node);
                
                if (node.CompareTo(target) == 0) return res;
                
                var nexts = GetNexts(node, visited);
                foreach(var n in nexts) {
                    queue.Enqueue(n);
                }
            }
            
            res++;
        }
        
        return -1;
    }
    
    public List<string> GetNexts(string s, HashSet<string> visited) {
        var res = new List<string>();
        
        for (var i = 0; i < s.Length; i++) {
            var pre = s.Substring(0, i);
            var pos = s.Substring(i + 1);
            var c1 = (char)(s[i] == '0' ? '9' : s[i] - 1);
            var c2 = (char)(s[i] == '9' ? '0' : s[i] + 1);
            var s1 = new string(pre + c1 + pos);
            var s2 = new string(pre + c2 + pos);
            
            if (!visited.Contains(s1)) {
                res.Add(s1);
                visited.Add(s1);
            }
            
            if (!visited.Contains(s2)) {
                res.Add(s2);
                visited.Add(s2);
            }
        }
        
        return res;
    }
}