/*
 * Link: https://leetcode.com/problems/fruit-into-baskets/
 * Author: Dung Nguyen Tien (Chris)
*/

public class Solution {
    public int TotalFruit(int[] tree) {
        var map = new Dictionary<int, int>();
        int begin = 0, end = 0;
        int max = 0;
        
        while(end < tree.Length) {
            var n = tree[end++];
            
            if (!map.ContainsKey(n)) map.Add(n, 0);
            map[n]++;
            
            while(map.Count > 2) {
                var remove = tree[begin++];
                
                map[remove]--;
                if (map[remove] == 0) map.Remove(remove);
            }
            
            max = Math.Max(max, end - begin);
        }
        
        return max;
    }
}