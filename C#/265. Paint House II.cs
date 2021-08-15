public class Solution {
    public int MinCostII(int[][] costs) {
        if (costs.Length == 0 || costs[0].Length == 0) return 0;
        
        int preMin1 = 0, preMin2 = 0, iPreMin = -1;
        int k = costs[0].Length;
        
        if (k == 1) {
            return costs.Length == 1 ? costs[0][0] : -1;
        }
        for(var i = 0; i < costs.Length; i++) {
            int min1 = Int32.MaxValue, min2 = Int32.MaxValue, imin = -1;
            
            for (var j = 0; j < k; j++) {
                int val = costs[i][j] + (j == iPreMin ? preMin2 : preMin1);
                
                if (val < min1) {
                    min2 = min1;
                    min1 = val;
                    imin = j;
                }
                else if (val < min2) {
                    min2 = val;
                }
            }
            
            preMin1 = min1;
            preMin2 = min2;
            iPreMin = imin;
        }
        
        return preMin1;
    }
}