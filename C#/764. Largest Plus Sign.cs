public class Solution {
    public int OrderOfLargestPlusSign(int n, int[][] mines) {
        var map = CreateMap(n, mines);
        
        for(var i = 0; i < n; i++){
            int l = 0, r = 0;
            for(var j = 0; j < n;j++){
                if (map[i][j] == 0) l = 0;
                else {
                    l++;
                    map[i][j] = Math.Min(map[i][j] ,l);
                }
                
                if (map[i][n - j - 1] == 0) r = 0;
                else {
                    r++;
                    map[i][n - j - 1] = Math.Min(map[i][n - j - 1], r);
                }
            }
        }
        
        for(var j = 0; j < n;j++){
            int u = 0, d = 0;
            for(var i = 0; i < n;i++){
                if (map[i][j] == 0) u = 0;
                else {
                    u++;
                    map[i][j] = Math.Min(map[i][j], u);
                }
                
                if (map[n - i - 1][j] == 0) d = 0;
                else {
                    d++;
                    map[n - i - 1][j] = Math.Min(map[n - i - 1][j], d);
                }
            }
        }
        
        var ans = 0;
        for(var i =0; i < n; i++)
            for(var j = 0; j < n; j++)
                ans = Math.Max(ans, map[i][j]);
        return ans;
    }
    
    public int[][] CreateMap(int n, int[][] mines) {
        var res = new int[n][];
        
        for(var i = 0; i < n; i++) {
            res[i] = new int[n];
            
            for(var j = 0; j < n; j++) {
                res[i][j] = n;
            }
        }
        
        foreach(var m in mines) {
            res[m[0]][m[1]] = 0;
        }
        
        return res;
    }
}