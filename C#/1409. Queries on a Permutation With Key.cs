/*
 * Link: https://leetcode.com/problems/queries-on-a-permutation-with-key/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int[] ProcessQueries(int[] queries, int m) {
        var list = CreateList(m);
        var result = new int[queries.Length];
        Array.Fill(result, 0);
        
        for (var i = 0; i < queries.Length; i++) {
            var q = queries[i];
            var index = list.IndexOf(q);
            
            result[i] = index;
            list.RemoveAt(index);
            list.Insert(0, q);
        }
        
        return result;
    }
    
    public List<int> CreateList(int m) {
        var list = new List<int>();
        
        for(var i = 1; i <= m; i++) list.Add(i);
        
        return list;
    }
}