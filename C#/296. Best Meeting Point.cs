public class Solution {
    public int MinTotalDistance(int[][] grid) {
        int m = grid.Length, n = grid[0].Length;
        List<int> cols = new List<int>(), rows = new List<int>();
        
        for(var i = 0; i < m; i++) {
            for (var j = 0; j < n; j++) {
                if (grid[i][j] == 1) {
                    rows.Add(i);
                    cols.Add(j);
                }
            }
        }
        
        return FindMin(cols) + FindMin(rows);
    }
    
    public int FindMin(List<int> li){
        int res = 0;
        
        li.Sort();
        
        int left = 0, right = li.Count - 1;
        while(left < right) {
            res += li[right--] - li[left++];
        }
        
        return res;
    }
}