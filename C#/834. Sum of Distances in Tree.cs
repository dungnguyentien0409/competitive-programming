public class Solution {
    int[] res, count;
    Dictionary<int, HashSet<int>> map;
    
    public int[] SumOfDistancesInTree(int n, int[][] edges) {
        map = CreateMap(n);
        res = new int[n]; 
        count = new int[n];
        
        foreach(var e in edges) {
            map[e[0]].Add(e[1]);
            map[e[1]].Add(e[0]);
        }
        
        PreOrder(0, -1);
        PostOrder(0, -1);
        
        return res;
    }
    
    public void PreOrder(int root, int pre) {
        foreach(var i in map[root]) {
            if (i == pre) continue;
            
            PreOrder(i, root);
            
            count[root] += count[i];
            res[root] += res[i] + count[i];
        }
        
        count[root]++;
    }
    
    public void PostOrder(int root, int pre) {
        foreach(var i in map[root]) {
            if (i == pre) continue;
            
            res[i] = res[root] - count[i] + count.Length - count[i];
            
            PostOrder(i, root);
        }
    }
    
    public Dictionary<int, HashSet<int>> CreateMap(int n) {
        var map = new Dictionary<int, HashSet<int>>();
        
        for(var i = 0; i < n; i++) {
           map.Add(i, new HashSet<int>()); 
        }
        
        return map;
    }
}