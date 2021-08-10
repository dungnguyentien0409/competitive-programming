public class Solution {
    public int MinFlipsMonoIncr(string s) {
        int c1 = 0, c0 = 0;
        
        foreach(var c in s) {
            if (c == '1') c1++;
            else c0++;
            
            c0 = Math.Min(c0, c1);
        }
        
        return c0;
    }
}