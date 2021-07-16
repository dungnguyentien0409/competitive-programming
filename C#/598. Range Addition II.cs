public class Solution {
    public int MaxCount(int m, int n, int[][] ops) {
        if (ops.Length == 0) return m * n;
        
        int min_m = ops[0][0];
        int min_n = ops[0][1];
        foreach(var op in ops) {
            min_m = Math.Min(min_m, op[0]);
            min_n = Math.Min(min_n, op[1]);
        }
        
        return min_m * min_n;
    }
}