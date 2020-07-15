/*
 * Link: https://leetcode.com/problems/kill-process/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public IList<int> KillProcess(IList<int> pid, IList<int> ppid, int kill) {
        var map = CreateMap(pid, ppid);
        var res = new List<int>();
        var queue = new Queue<int>();
        
        queue.Enqueue(kill);
        while(queue.Count > 0) {
            var len = queue.Count;
            
            for (var i = 0; i < len; i++) {
                var current = queue.Dequeue();
                
                res.Add(current);
                
                if (map.ContainsKey(current)) {
                    foreach(var child in map[current]) {
                        queue.Enqueue(child);
                    }
                }
            }
        }
        
        return res;
    }
    
    public Dictionary<int, List<int>> CreateMap(IList<int> pid, IList<int> ppid) {
        var map = new Dictionary<int, List<int>>();
        
        for (var i = 0; i < ppid.Count; i++) {
            if (!map.ContainsKey(ppid[i])) map.Add(ppid[i], new List<int>());
            
            map[ppid[i]].Add(pid[i]);
        }
        
        return map;
    }
}