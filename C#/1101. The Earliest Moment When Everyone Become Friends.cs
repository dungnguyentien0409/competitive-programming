/*
 * Link: https://leetcode.com/problems/the-earliest-moment-when-everyone-become-friends/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int EarliestAcq(int[][] logs, int N) {
        Array.Sort(logs, delegate(int[] log1, int[] log2) {
           return log1[0] - log2[0]; 
        });
        
        var uf = new UnionFind(N);
        for(var i = 0; i < logs.Length; i++) {
            var log = logs[i];
            
            uf.Union(log[1], log[2]);

            if (uf.numberParent == 1) return log[0];
        }
        
        return -1;
    }
}

public class UnionFind {
    public int[] parent;
    public int numberParent;
    
    public UnionFind(int N) {
        numberParent = N;
        parent = new int[N];
        
        for (var i = 0; i < N; i++) {
            parent[i] = i;
        }
    }
    
    public int FindParent(int x) {
        if (parent[x] == x) return x;
        
        var p = FindParent(parent[x]);
        parent[x] = p;
        
        return p;
    }
    
    public void Union(int x, int y) {
        if (parent[x] != parent[y]);
        
        var pX = FindParent(x);
        var pY = FindParent(y);
        
        if (pX != pY) {
            parent[pX] = pY;
            numberParent--;
        }
    }
}