public class Solution {
    public int[] GetModifiedArray(int length, int[][] updates) {
        var res = new int[length];
        
        foreach(var u in updates) {
            int start = u[0], end = u[1], val = u[2];
            res[start] += val;
            if (end < length - 1)
                res[end + 1] -= val;
        }
        
        for(var i = 1; i < length; i++) {
            res[i] += res[i - 1];
        }
        
        return res;
    }
}