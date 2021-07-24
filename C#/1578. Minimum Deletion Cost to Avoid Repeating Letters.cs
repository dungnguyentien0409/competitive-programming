public class Solution {
    public int MinCost(string s, int[] cost) {
        if (s.Length == 0) return 0;
        
        int res = 0, pre = 0;
        for(var i = 1; i < s.Length; i++) {
            if (s[pre] == s[i]) {
                res += Math.Min(cost[pre], cost[i]);
                
                if (cost[pre] < cost[i]) {
                    pre = i;
                }
            }
            else {
                pre = i;
            }
        }
        
        return res;
    }
}